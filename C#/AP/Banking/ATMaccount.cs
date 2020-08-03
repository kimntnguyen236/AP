using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class ATMaccount
    {
        private string AccNo;
        private int Balance;


        public ATMaccount()
        {
            input();
        }

        //property pAccNo cho AccNo
        public string pAccNo
        {
            get
            {
                return AccNo;

            }
            set
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(value.Trim(), "^ACC-\\d{4}$"))
                {
                    AccNo = value.Trim();

                }
                else
                {
                    Console.WriteLine("Ma so tai khoan khong hop le");
                }
            }


        }

        // write only property pDeposit (Nap tien vo tai khoan)
        public int pDeposit
        {
            set
            {
                if (value >= 100)
                {
                    Balance += value;

                }
                else
                {
                    Console.WriteLine("LOi: so tien nap phai lon hon >= 100  !!");
                }
            }
        }

        //write-only property pWithdraw (rut tien khoi tai khoan)
        public int pWithdraw
        {
            set
            {
                if (value >= 100 && value < Balance)
                {
                    Balance -= value;

                }
                else
                {
                    Console.WriteLine("LOi: so tien rut phai lon hon >= 100 va nho hon so du hien tai  {0}!!", Balance);
                }
            }
        }
        //write-only property pBalance (xem so du tai khoan)
        public int pBalance
        {
            get
            {
                return Balance;
            }
        }

        public void input()
        {
            Console.WriteLine("Nhap thong tin chi tiet");
            while (true)
            {
                try
                {
                    Console.WriteLine("Nhap ma so tai khoan TK[ACC-xxxx]: ");
                    pAccNo = Console.ReadLine().Trim();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }

            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Nhap so du bang dau > 100: ");
                    pDeposit = int.Parse(Console.ReadLine().Trim());
                    if (Balance > 0)
                    {
                        break;

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Loi: " + e.Message);

                }

            }


        }
        public override string ToString()
        {
            return string.Format("Ma TK: {0}, So du: {1},", AccNo, Balance);
        }
    }
}

