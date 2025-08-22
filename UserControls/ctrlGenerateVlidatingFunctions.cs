using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGeneratore_0._1.UserControls
{
    public partial class ctrlGenerateVlidatingFunctions : UserControl
    {
        public ctrlGenerateVlidatingFunctions()
        {
            InitializeComponent();
        }


        private void btnGenerateAllFunctions_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Text.RegularExpressions;");
            sb.AppendLine("using System.Windows.Forms;");
            sb.AppendLine();
            sb.AppendLine("public static class ValidationHelper");
            sb.AppendLine("{");

            // Required
            sb.AppendLine("    public static bool IsRequired(string value) => !string.IsNullOrWhiteSpace(value);");
            sb.AppendLine();

            // Only String
            sb.AppendLine("    public static bool IsStringOnly(string value)");
            sb.AppendLine("    {");
            sb.AppendLine("        if (string.IsNullOrWhiteSpace(value)) return false;");
            sb.AppendLine("        return Regex.IsMatch(value, \"^[a-zA-Z]+$\");");
            sb.AppendLine("    }");
            sb.AppendLine();

            // Only Numbers
            sb.AppendLine("    public static bool IsNumericOnly(string value)");
            sb.AppendLine("    {");
            sb.AppendLine("        if (string.IsNullOrWhiteSpace(value)) return false;");
            sb.AppendLine("        return Regex.IsMatch(value, \"^[0-9]+$\");");
            sb.AppendLine("    }");
            sb.AppendLine();

            // String Validation for TextBox
            sb.AppendLine("    public static void ValidateStringTextBox(TextBox txt, ErrorProvider errorProvider = null)");
            sb.AppendLine("    {");
            sb.AppendLine("        if (!IsStringOnly(txt.Text))");
            sb.AppendLine("        {");
            sb.AppendLine("            txt.Clear();");
            sb.AppendLine("            txt.Focus();");
            sb.AppendLine("            if (errorProvider != null) errorProvider.SetError(txt, \"Only letters are allowed.\");");
            sb.AppendLine("        }");
            sb.AppendLine("        else if (errorProvider != null) errorProvider.SetError(txt, \"\");");
            sb.AppendLine("    }");
            sb.AppendLine();

            // Numeric Validation for TextBox
            sb.AppendLine("    public static void ValidateNumericTextBox(TextBox txt, ErrorProvider errorProvider = null)");
            sb.AppendLine("    {");
            sb.AppendLine("        if (!IsNumericOnly(txt.Text))");
            sb.AppendLine("        {");
            sb.AppendLine("            txt.Clear();");
            sb.AppendLine("            txt.Focus();");
            sb.AppendLine("            if (errorProvider != null) errorProvider.SetError(txt, \"Only numbers are allowed.\");");
            sb.AppendLine("        }");
            sb.AppendLine("        else if (errorProvider != null) errorProvider.SetError(txt, \"\");");
            sb.AppendLine("    }");
            sb.AppendLine();

            // Email
            sb.AppendLine("    public static bool IsEmail(string value)");
            sb.AppendLine("    {");
            sb.AppendLine("        if (string.IsNullOrWhiteSpace(value)) return false;");
            sb.AppendLine("        return Regex.IsMatch(value, @\"^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$\");");
            sb.AppendLine("    }");
            sb.AppendLine();

            // Min/Max Length
            sb.AppendLine("    public static bool IsInLengthRange(string value, int min, int max) => value != null && value.Length >= min && value.Length <= max;");
            sb.AppendLine();

            // Min/Max Value
            sb.AppendLine("    public static bool IsInValueRange(double value, double min, double max) => value >= min && value <= max;");
            sb.AppendLine();

            // Regex Pattern
            sb.AppendLine("    public static bool IsMatchPattern(string value, string pattern)");
            sb.AppendLine("    {");
            sb.AppendLine("        if (string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(pattern)) return false;");
            sb.AppendLine("        return Regex.IsMatch(value, pattern);");
            sb.AppendLine("    }");

            sb.AppendLine("}");

            txtGeneratedCode.Text = sb.ToString();
        }


        private void btngenrateFunction_Click(object sender, EventArgs e)
        {
            // this function generates a single validation function based on the selected checkboxes
            GetErrorsIfSomeRequiredNotChecked();

            string propertyName = txtParameters.Text.Trim();
            string dataType = txtDataType.Text.Trim();
            string functionName = txtFunctionName.Text.Trim();
            string code = "";

            if (chkRequired.Checked)
            {
                code = GenerateRequiredFunction(propertyName, functionName);
            }
            else if (chkNumeric.Checked)
            {
                code = GenerateNumericFunction(propertyName, functionName);
            }
            else if (chkMinLength.Checked)
            {
                int min = int.Parse(txtMinLength.Text);
                code = GenerateMinLengthFunction(propertyName, functionName, min);
            }
            else if (chkMaxLength.Checked)
            {
                int max = int.Parse(txtMaxLength.Text);
                code = GenerateMaxLengthFunction(propertyName, functionName, max);
            }
            else if (chkEmail.Checked)
            {
                code = GenerateEmailFunction(propertyName, functionName);
            }
            else if (chkPattern.Checked)
            {
                string pattern = txtRegexPattern.Text.Trim();
                code = GeneratePatternFunction(propertyName, functionName, pattern);
            }
            else if (chkMinValue.Checked)
            {
                int minVal = int.Parse(txtMinValue.Text);
                code = GenerateMinValueFunction(propertyName, functionName, minVal);
            }
            else if (chkMaxValue.Checked)
            {
                int maxVal = int.Parse(txtMaxValue.Text);
                code = GenerateMaxValueFunction(propertyName, functionName, maxVal);
            }

            txtGeneratedCode.Text = code;
        }

        private string GenerateRequiredFunction(string property, string functionName)
        {
            return $@"
              public bool {functionName}(string {property})
              {{
                  return !string.IsNullOrWhiteSpace({property});
              }}";
        }

        private string GenerateNumericFunction(string property, string functionName)
        {
            return $@"
              public bool {functionName}(string {property})
              {{
                  return int.TryParse({property}, out _);
              }}";
        }

        private string GenerateMinLengthFunction(string property, string functionName, int min)
        {
            return $@"
              public bool {functionName}(string {property})
              {{
                  return !string.IsNullOrEmpty({property}) && {property}.Length >= {min};
              }}";
        }

        private string GenerateMaxLengthFunction(string property, string functionName, int max)
        {
            return $@"
              public bool {functionName}(string {property})
              {{
                  return {property} != null && {property}.Length <= {max};
              }}";
        }

        private string GenerateEmailFunction(string property, string functionName)
        {
            return $@"
              public bool {functionName}(string {property})
              {{
                  return System.Text.RegularExpressions.Regex.IsMatch({property},
                      @""^[^@\s]+@[^@\s]+\.[^@\s]+$"");
              }}";
        }

        private string GeneratePatternFunction(string property, string functionName, string pattern)
        {
            return $@"
               public bool {functionName}(string {property})
               {{
                   return System.Text.RegularExpressions.Regex.IsMatch({property}, @""{pattern}"");
               }}";
        }

        private string GenerateMinValueFunction(string property, string functionName, int min)
        {
            return $@"
              public bool {functionName}(int {property})
              {{
                  return {property} >= {min};
              }}";
        }

        private string GenerateMaxValueFunction(string property, string functionName, int max)
        {
            return $@"
              public bool {functionName}(int {property})
              {{
                  return {property} <= {max};
              }}";
        }

        private void GetErrorsIfSomeRequiredNotChecked()
        {
            bool hasError = false;
            errorProvider1.Clear(); // remove any previous errors

            // check if at least one checkbox is checked
            if (string.IsNullOrWhiteSpace(txtParameters.Text))
            {
                errorProvider1.SetError(txtParameters, "Property name is required.");
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(txtFunctionName.Text))
            {
                errorProvider1.SetError(txtFunctionName, "Function name is required.");
                hasError = true;
            }

            // check if at least one checkbox is checked
            if (chkMinLength.Checked && string.IsNullOrWhiteSpace(txtMinLength.Text))
            {
                errorProvider1.SetError(txtMinLength, "Minimum length is required.");
                hasError = true;
            }

            if (chkMaxLength.Checked && string.IsNullOrWhiteSpace(txtMaxLength.Text))
            {
                errorProvider1.SetError(txtMaxLength, "Maximum length is required.");
                hasError = true;
            }

            if (chkMinValue.Checked && string.IsNullOrWhiteSpace(txtMinValue.Text))
            {
                errorProvider1.SetError(txtMinValue, "Minimum value is required.");
                hasError = true;
            }

            if (chkMaxValue.Checked && string.IsNullOrWhiteSpace(txtMaxValue.Text))
            {
                errorProvider1.SetError(txtMaxValue, "Maximum value is required.");
                hasError = true;
            }

            if (chkPattern.Checked && string.IsNullOrWhiteSpace(txtRegexPattern.Text))
            {
                errorProvider1.SetError(txtRegexPattern, "Regex pattern is required.");
                hasError = true;
            }

            if (hasError) return; // if there are errors, stop here

            // if no errors, generate the code
            string code = GenerateSelectedFunction();
            txtGeneratedCode.Text = code;

        }

        private string GenerateSelectedFunction()
        {
            string propertyName = txtParameters.Text.Trim();
            string functionName = txtFunctionName.Text.Trim();
            string code = "";

            if (chkRequired.Checked)
                code = GenerateRequiredFunction(propertyName, functionName);
            else if (chkNumeric.Checked)
                code = GenerateNumericFunction(propertyName, functionName);
            else if (chkMinLength.Checked)
                code = GenerateMinLengthFunction(propertyName, functionName, int.Parse(txtMinLength.Text));
            else if (chkMaxLength.Checked)
                code = GenerateMaxLengthFunction(propertyName, functionName, int.Parse(txtMaxLength.Text));
            else if (chkEmail.Checked)
                code = GenerateEmailFunction(propertyName, functionName);
            else if (chkPattern.Checked)
                code = GeneratePatternFunction(propertyName, functionName, txtRegexPattern.Text.Trim());
            else if (chkMinValue.Checked)
                code = GenerateMinValueFunction(propertyName, functionName, int.Parse(txtMinValue.Text));
            else if (chkMaxValue.Checked)
                code = GenerateMaxValueFunction(propertyName, functionName, int.Parse(txtMaxValue.Text));

            return code;
        }

        private void btnClearTxtBox_Click(object sender, EventArgs e)
        {
            txtGeneratedCode.Clear();
        }
    }
}
