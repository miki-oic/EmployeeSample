namespace WinFormsApp1
{

    public class Employee
    {

        /// <summary>
        /// 社員ID
        /// </summary>
        private string id = string.Empty;
        /// <summary>
        /// 氏 名
        /// </summary>
        private string name = string.Empty;
        /// <summary>
        /// メール
        /// </summary>
        private string mailAddress = string.Empty;

        public Employee(string id)
        {

            SetID(id);

        }

        public Employee(string id, string name, string mailAddress)
        {

            SetID(id);
            SetName(name);
            SetGetMailAddress(mailAddress);

        }

        public string GetID()
        {
            
            return id;
        
        }

        private Employee SetID(string id)
        {

            this.id = id;

            return this;

        }

        public string GetName()
        {

            return name;

        }

        public Employee SetName(string name)
        {

            this.name = name;

            return this;

        }

        public string GetMailAddress()
        {

            return mailAddress;

        }

        public Employee SetGetMailAddress(string mailAddress)
        {

            this.mailAddress = mailAddress;

            return this;

        }

        public string Status {
            
            get
            {

                return status;

            }
        
        }

        /// <summary>
        /// 状 態
        /// </summary>
        private string status = string.Empty;
        //
        private int statusNumber = 0;
        public int StatusNumber { get; set; }

    }

}