using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppClassLibrary
{
    public class clsDbTablenames
    {
        // LOKALE KONSTANTEN VARIABLEN DEKLARIEREN:

        //Tabellename Account
        public string STR_TBL_ACCOUNT = "Accounts";
        public string STR_TBL_CUSTOMER = "Customers";
        public string STR_TBL_TRANSACTIONS = "Transactions";

        // Spaltename der Datenbank.
        public string STR_FN_ID_ACCOUNT = "AccountID";
        public string STR_FN_ID_CUSTOMER = "CustomerID";
        public string STR_FN_IBAN = "IBAN";
        public string STR_FN_ACCOUNT_TYPE = "AccountType";
        public string STR_FN_BALANCE = "BALANCE";
        public string STR_FN_CREATEDAT = "CreatedAt";
        public string STR_FN_FIRSTNAME = "FirstName";
        public string STR_FN_LASTNAME = "LastName";
        public string STR_FN_EMAIL = "Email";
        public string STR_FN_PHONE = "Phone";
        public string STR_FN_STREET = "Street";
        public string STR_FN_HOUSNUMBER = "Housenumber";
        public string STR_FN_CITY = "City";    
        public string STR_FN_ID_TRANSACTION = "TransactionID";     
        public string STR_FN_ZIPCODE = "ZipCode";
        public string STR_FN_TRANSACTION_TYPE = "TransactionType";
        public string STR_FN_AMOUNT = "Amount";
        public string STR_FN_TRANSACTION_DATE = "TransactionDate";
        public string STR_FN_TRANSACTION_NR = "TransactionNr";
        public string STR_PURPOSE = "Purpose";
        
    }
}
