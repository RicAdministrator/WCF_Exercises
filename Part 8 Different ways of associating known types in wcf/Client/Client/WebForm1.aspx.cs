using System;
using Client.EmployeeService;

namespace Client
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGet_Click(object sender, EventArgs e)
        {
            EmployeeServiceClient client = new EmployeeServiceClient();
            Employee employee = client.GetEmployee(Convert.ToInt32(txtId.Text));

            if (employee.Type == EmployeeType.FullTimeEmployee)
            {
                txtAnnualSalary.Text =
                    ((FullTimeEmployee)employee).AnnualSalary.ToString();
                trAnnualSalary.Visible = true;
                trHourlPay.Visible = false;
                trHoursWorked.Visible = false;
            }
            else
            {
                txtHourlyPay.Text =
                    ((PartTimeEmployee)employee).HourlyPay.ToString();
                txtHoursWorked.Text =
                    ((PartTimeEmployee)employee).HoursWorked.ToString();
                trAnnualSalary.Visible = false;
                trHourlPay.Visible = true;
                trHoursWorked.Visible = true;
            }
            ddlEmployeeType.SelectedValue = ((int)employee.Type).ToString();

            txtFirstName.Text = employee.FirstName;
            txtLastName.Text = employee.LastName;
            txtGender.Text = employee.Gender;
            txtDateOfBirth.Text = employee.DateOfBirth.ToShortDateString();
            lblMessage.Text = "Employee retrieved";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            EmployeeServiceClient client = new EmployeeServiceClient();
            Employee employee = null;

            EmployeeType employeeType = (EmployeeType)Convert.ToInt32(ddlEmployeeType.SelectedValue);

            if (employeeType == EmployeeType.FullTimeEmployee)
            {
                employee = new FullTimeEmployee
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Gender = txtGender.Text,
                    DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text),
                    Type = employeeType,
                    AnnualSalary = Convert.ToInt32(txtAnnualSalary.Text),
                };
                client.SaveEmployee(employee);
                lblMessage.Text = "Employee saved";
            }
            else if (employeeType == EmployeeType.PartTimeEmployee)
            {
                employee = new PartTimeEmployee
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Gender = txtGender.Text,
                    DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text),
                    Type = employeeType,
                    HourlyPay = Convert.ToInt32(txtHourlyPay.Text),
                    HoursWorked = Convert.ToInt32(txtHoursWorked.Text),
                };
                client.SaveEmployee(employee);
                lblMessage.Text = "Employee saved";
            }
            else
            {
                lblMessage.Text = "Please select Employee Type";
            }
        }

        protected void ddlEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            trAnnualSalary.Visible = ddlEmployeeType.SelectedValue == "1";
            trHourlPay.Visible = ddlEmployeeType.SelectedValue == "2";
            trHoursWorked.Visible = ddlEmployeeType.SelectedValue == "2";
        }
    }
}