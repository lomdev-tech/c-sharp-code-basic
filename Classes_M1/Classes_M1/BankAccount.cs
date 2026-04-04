using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_M1
{
    public class BankAccount
    {
        public readonly int AccountNumber;//银行卡号
        public static double InterestRate;//存储利率
        public readonly string CustomerId;//客户ID
        private static int s_nextAccountNumber = 1;//存储下一个账户号码
        public double Balance { get; set; } = 0;//自动实现的属性 初始化值为0
        public string AccountType { get; set; } = "Checking";


        public BankAccount(string customerIdNumber)
        {
            this.AccountNumber = s_nextAccountNumber++;
            this.CustomerId = customerIdNumber;
        }

        public BankAccount(string customerIdNumber, double balance,string accountType) {
            this.AccountNumber = s_nextAccountNumber++;
            this.CustomerId = customerIdNumber;
            this.Balance = balance;
            this.AccountType = accountType;



        }
        /// <summary>
        /// 静态构造器：只生成一份 一般形式 用于共享 
        /// </summary>
        static BankAccount() {
            Random random = new();
            InterestRate = 0;//不同的账户类型 利率不同 所以初始化为0
            s_nextAccountNumber = random.Next(10000000,20000000); 
        }
    }
}
