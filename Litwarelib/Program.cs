namespace LitwareLib
{

    /// <remarks>
    /// Represents details of employees and Provides a function to calculate PF, TDS and Net Salary of Employees.
    /// </remarks>
    public class Employee
    {
        private int _empNo;
        private string _empName;
        private double _salary;
        private double _hra;
        private double _ta;
        private double _da;
        private double _pf;
        private double _tds;
        private double _netSalary;
        private double _grossSalary;

        public int EmpNo
        {
            get { return _empNo; }
            set { _empNo = value; }
        }

        public string EmpName
        {
            get { return _empName; }
            set { _empName = value; }
        }

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public double Hra
        {
            get
            {
                if (this._salary < 5000)
                {
                    _hra = 0.10 * _salary;
                }
                else if (this._salary < 10000)
                {
                    _hra = 0.15 * _salary;
                }
                else if (this._salary < 15000)
                {
                    _hra = 0.2 * _salary;
                }
                else if (this._salary < 20000)
                {
                    _hra = 0.25 * _salary;
                }
                else if (this._salary >= 20000)
                {
                    _hra = 0.3 * _salary;
                }
                return _hra;
            }

        }

        public double Ta
        {

            get
            {
                if (this._salary < 5000)
                {
                    _ta = 0.5 * _salary;
                }
                else if (this._salary < 10000)
                {
                    _ta = 0.10 * _salary;
                }
                else if (this._salary < 15000)
                {
                    _ta = 0.15 * _salary;
                }
                else if (this._salary < 20000)
                {
                    _ta = 0.20 * _salary;
                }
                else if (this._salary >= 20000)
                {
                    _ta = 0.25 * _salary;
                }
                return _ta;
            }

        }

        public double Da
        {
            get
            {
                if (this._salary < 5000)
                {
                    _da = 0.15 * _salary;
                }
                else if (this._salary < 10000)
                {
                    _da = 0.20 * _salary;
                }
                else if (this._salary < 15000)
                {
                    _da = 0.25 * _salary;
                }
                else if (this._salary < 20000)
                {
                    _da = 0.30 * _salary;
                }
                else if (this._salary >= 20000)
                {
                    _da = 0.35 * _salary;
                }
                return _da;
            }

        }

        public double Pf
        {
            set { _pf = value; }
            get => _pf;
        }

        public double Tds
        {
            set { _tds = value; }
            get => _tds;
        }

        public double NetSalary
        {
            set { _netSalary = value; }
            get => _netSalary;
        }

        public double GrossSalary
        {
            get
            {
                _grossSalary = _salary + Hra + Ta + Da;
                return _grossSalary;
            }
        }

        /// <summary>
        /// Calculates PF, TDS and Net Salary of an Employee.
        /// </summary>
        public void CalculateSalary()
        {
            Pf = 0.1 * GrossSalary;
            Tds = 0.18 * GrossSalary;
            NetSalary = GrossSalary - (_pf + _tds);
        }

    }

}