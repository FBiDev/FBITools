using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FBITools
{
    public static class VbToCsharp
    {
        private static string codeConverted;
        private static string handles;

        public static string Convert(string text)
        {
            handles = RemoveHandles(text);
            codeConverted = ConvertVBNetToCSharp(text);

            return handles + codeConverted;
        }

        private static string RemoveHandles(string vbNetCode)
        {
            string bufferHandles = "//Constructor Class" + "\r\n";

            var patternHandles = @"\bSub\s+(\w+)\s*\((.*)\)\s+Handles\s+([\w\.]+)\b";
            var replaceHandles = @"$3 += $1" + "\r\n";

            foreach (Match result in Regex.Matches(vbNetCode, patternHandles, RegexOptions.IgnoreCase))
            {
                if (result.Success)
                {
                    var cExtracted = result.Groups[0].ToString();
                    cExtracted = Regex.Replace(cExtracted, patternHandles, replaceHandles, RegexOptions.IgnoreCase);
                    bufferHandles += cExtracted;
                }
            }

            bufferHandles += "//Constructor Class" + "\r\n\r\n";

            var replaces = new Dictionary<string, string>
            {
                { @"\bMe\.\b", "this." }
            };

            foreach (KeyValuePair<string, string> item in replaces)
            {
                bufferHandles = Regex.Replace(bufferHandles, item.Key, item.Value);
            }

            return bufferHandles;
        }

        private static string IIfEquals(string vbNetCode)
        {
            var patternIf = @"\bIIf\s*\((.*),";
            var patternIfContent = @"\s*(?<![=!><])=(?![=><])\s*";
            var replaceIfContent = @" == ";

            foreach (Match result in Regex.Matches(vbNetCode, patternIf, RegexOptions.IgnoreCase | RegexOptions.Multiline))
            {
                if (result.Success)
                {
                    var cExtracted = result.Groups[0].ToString();
                    var newExtracted = Regex.Replace(cExtracted, patternIfContent, replaceIfContent, RegexOptions.IgnoreCase | RegexOptions.Multiline);
                    vbNetCode = vbNetCode.Replace(cExtracted, newExtracted);
                }
            }

            return vbNetCode;
        }

        private static string IfEquals(string vbNetCode)
        {
            var patternIf = @"\bif\((.*)\)\{";
            var patternIfContent = @"\s*(?<![=!><])=(?![=><])\s*";
            var replaceIfContent = @" == ";

            foreach (Match result in Regex.Matches(vbNetCode, patternIf, RegexOptions.IgnoreCase | RegexOptions.Multiline))
            {
                if (result.Success)
                {
                    var cExtracted = result.Groups[0].ToString();
                    var newExtracted = Regex.Replace(cExtracted, patternIfContent, replaceIfContent, RegexOptions.IgnoreCase | RegexOptions.Multiline);
                    vbNetCode = vbNetCode.Replace(cExtracted, newExtracted);
                }
            }

            return vbNetCode;
        }

        private static string ConvertVBNetToCSharp(string vbNetCode)
        {
            // Comments (')
            vbNetCode = vbNetCode.Replace("'''", "///");

            string pattern = "(?<![^\"\n]\"[^\"\n]*)(?<![^'\n]'[^'\n]*)(')";

            vbNetCode = Regex.Replace(vbNetCode, pattern, delegate(Match match) { return "//" + match.Value.Substring(1); });

            vbNetCode = IIfEquals(vbNetCode);

            var replaces = new Dictionary<string, string>
            {
                // __ Imports
                // Imports System -> using System;
                { @"\bImports\s+([\w\.]+)", "using $1" },
                { @"\bAs\s+(\w+)\(\)", "As $1[]" },
                { @"\bAs\s+Int16\b", "As short" },
                { @"\bAs\s+Int32\b", "As int" },
                { @"\bAs\s+Integer\b", "As int" },
                { @"\bAs\s+String\b", "As string" },
                { @"\bAs\s+Date\b", "As DateTime" },
                { @"\bAs\s+datetime\b", "As DateTime" },
                { @"\bAs\s+Boolean\b", "As bool" },
                { @"\bAs\s+Object\b", "As object" },
                { @"\bAs\s+Byte\b", "As byte" },
                { @"\bByte\(\)", "byte[]" },

                // _Enum
                // End Enum -> }
                { @"\bEnd\s+Enum\b", "}" },

                // Enum Test -> enum Test
                { @"\bEnum\s+(\w+)\b", "enum $1{" },

                // __ Class
                // End Class -> }
                { @"\bEnd\s+Class\b", "}" },
                
                // Partial Public Class Test -> Public partial Class Test
                { @"\bPartial\s+(\w+)\s+Class\s+(\w+)\b", "$1 partial Class $2" },
                
                // Class Test Inherits TestBase, C2 ,C3 -> class Test : TestBase, C2 ,C3{
                { @"\bClass\s+(\w+)\s+Inherits\s+(\w+.*)", "class $1 : $2{\r" },
                
                // Class Test -> class Test{
                { @"\bClass\s+(\w+)\b+", "class $1{" },

                // __ Module
                // End Module -> }
                { @"\bEnd\s+Module\b", "}" },
                
                // Module Test -> static class Test{
                { @"\bModule\s+(\w+)\b", "static class $1{" },

                // "PDF", _\r\n Nothing -> "PDF", Nothing
                { @"([\w"")],)\s*_\s*(\r\n[\s']*)", "$1 $2" },

                // __ Function
                // End Function -> }
                { @"\bEnd\s+Function\b", "}" },
                
                // Function Test(*) As String -> String Test(*){
                { @"\bFunction\s+(\w+)\s*\(([\w ,._\s=/'""*]*)\)\s+As\s+([\w ().]+)", "$3 $1($2){" },
                
                // __ Sub
                // End Sub -> }
                { @"\bEnd\s+Sub\b", "}" },
                
                // Exit Sub -> break;
                { @"\bExit\s+Sub\b", "break;" },
                { @"\bSub\s+(\w+)\s*\((.*)\)\s+Handles\s+([\w\.]+)\b", @"Sub $1 ($2)" },
                
                // Sub Test(*) -> void Test(*){
                { @"\bSub\s+(\w+)\s*\(([\w ,._\s=/'*]*)\)", "void $1($2){" },
                
                // __ Interface
                // End Interface -> }
                { @"\bEnd\s+Interface\b", "}" },
                
                // Interface Test Inherits TestBase, C2 ,C3 -> interface Test : TestBase, C2 ,C3{
                { @"\bInterface\s+(\w+)\s+Inherits\s+(\w+.*)", "interface $1 : $2{\r" },
                
                // Interface Test -> interface Test{
                { @"\bInterface\s+(\w+)\b+", "interface $1{" },

                // __ Property
                // End Property -> }
                { @"\bEnd\s+Property\b", "}" },
                
                // End Get -> }
                { @"\bEnd\s+Get\b", "}" },
                
                // End Set -> }
                { @"\bEnd\s+Set\b", "}" },

                // ReadOnly Property -> Property }
                { @"\bReadOnly\s+Property\b", "Property" },
                
                // WriteOnly Property -> Property
                { @"\bWriteOnly\s+Property\b", "Property" },

                // Property Test As String = "10" -> String Test = "10";
                { @"\bProperty\s+(\w+)\s+As\s+(\w+)\s*=\s*([\w""]+)", "$2 $1 = $3;" },
                
                // Property Test As String -> String Test;
                { @"\bProperty\s+(\w+)\s+As\s+(\w+)\b", "$2 $1;" },
                
                // Property Count() As Integer -> Integer Test{
                { @"\bProperty\s+(\w+)\s*\(\s*\)\s+As\s+(\w+[\(\)\[\]]*)", "$2 $1{" },
                
                // Property Test -> Test{
                { @"\bProperty\s+(\w+)\(\)", "object $1{" },
                
                // Get -> get{
                { @"\bGet\s*\r\n", "get{\r\n" },
                
                // Set(*) -> set{
                { @"\bSet\s*\((.*)\)", "set{" },
                
                // Set -> set{
                { @"\bSet\s*\r\n", "set{\r\n" },
                
                // Test = value -> Test = value;
                { @"\b(\w+)\s*=\s*value\b", "$1 = value" },
                
                // __ Try
                // End Try -> }
                { @"\bEnd\s+Try\b", "}" },
                
                // Try -> try{
                { @"\bTry\s*\r\n", "try{\r\n" },
                
                // Finally
                { @"\bFinally\s*\r\n", "}finally{\r\n" },
                
                // Catch ex As Exception -> }catch(Exception ex){
                { @"\bCatch\s+(\w+)\s+As\s+(\w+)\b", "}catch($2 $1){" },
                
                // __ IIf
                { @"\bIIf[\t ]*\(([^\r,]+),([^\r,]+),([^\r,]+)\)", "(($1) ? $2 : $3)" },

                // __ If
                // End If -> }
                { @"\bEnd\s+If\b", "}" },
                { @"\bIf\s*\((.*)\)\s+Then", "if($1){" },
                
                // If ( -> if(
                { @"\bIf\s*\(\b", "if(" },
                
                // If -> if(
                { @"\bIf\s+\b", "if(" },
                
                // ElseIf a = 10 Then -> }else if(a = 10){
                { @"\bElseIf\s+([^\r]+)(?<![ Then\b])", "}else if($1" },
                
                // Then -> ){
                { @"\s+Then\b", "){" },
                
                // Case Else -> default
                { @"\bCase Else\b", "default" },
                
                // Else -> }else{
                { @"\bElse\b", "}else{" },

                // _ Select
                // Case 1 * -> case 1: * break;
                { @"(?<!Select )(\bCase\b|default)\s+([\w\.]*)[: ]*([\w\W\s]+?)(\r\n[\s'/]*)(?=([ ']\bCase\b|End Select|default))", "$1 $2: $3; break; $4" },
                
                // End Select -> }
                { @"\bEnd\s+Select\b", "}" },
                
                // Select Case Test -> switch(true){
                { @"\bSelect\s+Case\s+([\w\.]+)\b", "switch($1){" },
                { @"\bCase\b\s+", "case " },

                // __ While
                // End While -> }
                { @"\bEnd\s+While\b", "}" },
                
                // While dr.Read() -> while(dr.Read()){
                { @"\bWhile\s+(.+)\r", "while($1){\r" },
                
                // __ For Each
                // Next -> }
                { @"\bNext\b", "}" },
                
                // For Each item As DataRow In dt.Rows -> foreach(DataRow item in dt.Rows){
                { @"\bFor Each[\t ]([^\r]+)[\t ]+As[\t ]+([^\r]+)[\t ]+In[\t ]+([^\r]+)", "foreach($2 $1 in $3){" },

                // __ For
                // Exit For -> break;
                { @"\bExit For\b", "break;" },
                
                // For i As Int16 = 0 To Test.Count - 1 -> for(Int16 i = 0; i <= Test.Count - 1; i++){
                { @"\bFor\s+(.+)\s+As\s+(.+)\s+=\s+(.+)\s+To\s+(.+)\r", "for($2 $1 = $3; $1 <= $4; $1++){\r" },
                
                // __ CType
                // CType(Me.Master, Principal) -> ((Principal)Me.Master)
                { @"\bCType\s*\(([^\r]+)\s*,\s*([^\r\)]+[()]*)\s*\)", "(($2)$1)" },

                // __ List
                // As New List(Of String) -> List<String>
                { @"\b([^\r ]+)[ ]+As[ ]+New[ ]+([^\r ]+)\([ ]*Of[ ]+([^\r ]+)[ ]*\)", "$2<$3> $1 = new $2<$3>()" },
                
                // List(Of String) -> List<String>
                { @"\b([^\r ]+)\([ ]*Of[ ]+([^\r ]+)[ ]*\)", "$1<$2>" },
                
                // __ Region
                // #End Region -> #endregion
                { @"\#End\s+Region\b", "#endregion" },
                
                // #Region "Test" -> #region "Test"
                { @"#Region\s+([\w"" ]+)", "#region $1" },

                // __ Session
                // Session(item) = selectedItem -> Session[item] = selectedItem
                { @"\bSession[\t ]*\([\t ]*([^\r\t\) ]+)[\t ]*\)", "Session[$1]" },
                
                // __ Var Declaration
                { @"\b([Private|Protected|Public]+)[\t ]+([^\r ]+)[\t ]+As[\t ]+New[\t ]+([^\r \(\)]+)[\(\)]*", "$1 $3 $2 = new $3()" },
                
                // Dim Test As New Example() -> var Test = new Example();
                { @"\bDim[\t ]+([^\r ]+)[\t ]+As[\t ]+New[\t ]+([^\r \(]+)\(([\w ,.("")]*)\)", "var $1 = new $2($3)" },
                { @"\bDim[\t ]+([^\r ]+)[\t ]+As[\t ]+New[\t ]+([^\r \(]+)\b", "var $1 = new $2()" },
                
                // Dim Test = New -> var Test = new
                { @"\bDim\s+(\w+)\s*=\s*New ", "var $1 = new " },
                
                // Dim Test As String = -> String Test = 
                { @"\bDim\s+(\w+)\s+As\s+(\w+)\s*=\s*", "$2 $1 = " },
                
                // Dim Test() As String -> String[] Test;
                { @"\bDim[\t ]+([^\r ]+)\(\)[\t ]+As[\t ]+([^\r ]+)", "$2[] $1" },
                
                // Dim Test As String -> String Test;
                { @"\bDim[\t ]+([^\r ]+)[\t ]+As[\t ]+([^\r ]+)", "$2 $1" },
                
                // Fix Dim List to var
                { @"\bDim\s+List<[\w.()]+>\s+", "var " },
                
                // _id As Integer
                { @"(\w+)\s+As\s+(\w+)\s*\r\n", "$2 $1;\r\n" },

                // __ Parameters
                // ByRef e As System.EventArgs -> ref System.EventArgs e
                { @"\bByRef\s+(\w+)\s+As\s+([\w\.]+)", "ref $2 $1" },
                
                // ByVal e As System.EventArgs -> System.EventArgs e
                { @"\bByVal\s+(\w+)\s+As\s+([\w\.]+)", "$2 $1" },
                
                // e As String -> String e
                { @"\b(\w+)\s+As\s+([\w\.\[\]]+)", "$2 $1" },

                // __ Var change value
                // Test = New Examaple() -> Test = new Example();
                { @"\b([\w\.]+)\s*=\s*New\s+([^\r \(]+)[(]*([\w ,.]*)[)]*", "$1 = new $2($3)" },
                
                // Test = "X"C -> Test = 'X';
                { @"\b(\w+)\s*=\s*""(.{1})""(?i)C\b", "$1 = '$2'" },
                
                // __ Generic Words
                { @"\bMy.Settings.\b", "Settings.Default." },
                
                // Return 500 -> return 500;
                // .Rows(i)
                { @".Rows[\t ]*\([\t ]*([\w]+)[\t ]*\)", ".Rows[$1]" },
                
                // .Cells(i)
                { @".Cells[\t ]*\([\t ]*([\w]+)[\t ]*\)", ".Cells[$1]" },
                
                // .Tables(0) -> .Tables[0]
                { @".Tables\(0\)", ".Tables[0]" },
                
                // .DataSource(0) -> .DataSource[0]
                { @".DataSource\((\w+)\)", ".DataSource[$1]" },
                { @".Item\(([\w""]+)\)", ".Item[$1]" },
                
                // IsDBNull -> Convert.IsDBNull
                { @"(?<![.])\bIsDBNull\b", "Convert.IsDBNull" },
                
                // CInt(10) -> Convert.ToInt32("10")
                { @"\bCInt\(([\w"".()\[\]]+)\)", "Convert.ToInt32($1)" },
                
                // CDate() -> Convert.ToDateTime()
                { @"\bCDate\(([\w"".()\[\]]+)\)", "Convert.ToDateTime($1)" },
                
                // a" & _ "b -> a" + "b
                { @"([\w"")]{1})(\s+&\s+[_]{1})(\s*\r\n\s*"")", "$1 + $3" },
                
                // a & b -> a + b
                { @"([\w""\])]{1})(\s+&)(\s+[\w""(]{1})", "$1 + $3" },
                { @"\.(?i)count\b", ".Count" },
                { @"\bDate.MinValue\b", "DateTime.MinValue" },
                { @"\bMe\.\b", "this." },
                { @"\bNew\b", "new" },
                { @"\bAddHandler\s+([\w\.]+)\s*,\s*AddressOf\s+(\w+)\b", "$1 += $2" },
                { @"\bToString(?!\()\b", "ToString()" },
                { @"\bTrim(?!\()\b", "Trim()" },
                { @"\bRead(?!\()\b", "Read()" },
                { @"\bReturn\s+(.*)\b", "return $1" },
                { @"(\bRaiseEvent\s+)([\w]+)", "if($2 != null) $2" },
                { @"\bOverrides\s+", "override " },
                { @"\s+And\s+", " && " },
                { @"\bIs\s+Nothing\b", "== null" },
                { @"\bNothing\b", "null" },
                { @"\bNot\s+\b", "!" },
                { @"\bOr\b", "||" },
                { @"\bOptional\s+\b", string.Empty },
                { @"\s*<>\s*", " != " },
                { @"\bPublic\s+", "public " },
                { @"\bPrivate\s+", "private " },
                { @"\bProtected\s+", "protected " },

                // Shared -> static
                { @"\bShared\b", "static" },
                { @"\bOverloads\b", "new" },
                { @"\bOverridable\b", "virtual" },
                { @"\bEvent\s+(\w+)\(\)", "event Action $1" },
                { @"\bConst\b", "const" },
                { @"\bThrow\b", "throw" },
                { @"\bObject\b", "object" },
                { @"\bBoolean\b", "bool" },
                { @"\bString\b", "string" },
                { @"\bInteger\b", "int" },
                { @"\bTrue\b", "true" },
                { @"\bFalse\b", "false" },
                { @"ConfigurationManager.AppSettings\(([\w""]+)\)", "ConfigurationManager.AppSettings[$1]" },
                { @"ConfigurationManager.AppSettings.Item\(([\w""]+)\)", "ConfigurationManager.AppSettings.Item[$1]" },
                { @"ConfigurationManager.ConnectionStrings\(([\w""]+)\)", "ConfigurationManager.ConnectionStrings[$1]" },

                // Commas
                { @"(^[\s]*(?!#region\s|#endregion|\s|/{3}|/{2}\s*/{3})(?!.*[+{};>,][\r\t ]*$)[^\r]+(?<![\s]))", "$1;" }
            };

            foreach (KeyValuePair<string, string> item in replaces)
            {
                vbNetCode = Regex.Replace(vbNetCode, item.Key, item.Value, RegexOptions.Multiline);
            }

            vbNetCode = IfEquals(vbNetCode);

            return vbNetCode;
        }
    }
}