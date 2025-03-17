using System;

namespace SerializationAndDeserialization
{
    [Serializable]
    class employeeData
    {
        public int Id;
        public string empName;

        public employeeData(int Id, string empName)
        {
            this.Id = Id;
            this.empName = empName;
        }

    }
}
