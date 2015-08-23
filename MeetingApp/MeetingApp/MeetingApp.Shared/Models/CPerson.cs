using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingApp.Models
{
    class CPerson
    {
        // Klasa Osoba służy do przechowywania informacji o osobie zaproszonej
        // i ta klasa musi zwracac imie 
        private string mName;
        private string mSurname;
        //private CMeetings mMeeting;

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }
        public string Surname
        {
            get { return mSurname; }
            set { mSurname = value; }
        }

        // dodac wiek 
       // public CMeetings Meeting
       // {
       //     get { return mMeeting; }
       //     set { mMeeting = value; }
       // }

        public string ToString()
        {
            string mValueToReturn =
                "Imie :" + mName +
                "Nazwisko :" + mSurname;
              // "Miejsce:" + mMeeting.getLocation().ToString() +
              // "Data" + mMeeting.getDateOfMeetings().ToString() +
              // " Nazwa spotkania :" + mMeeting.getName() +
              // "Osoba zapraszajaca:";

            return mValueToReturn;
        }
        public CPerson(string aName, string aSurname/*, CMeetings aMeeting*/)
        {
            mName = aName;
            mSurname = aSurname;
         //   mMeeting = aMeeting;
        }

        public CPerson()
        {
            mName = "DefaultName";
            mSurname = "DefaultSurname";
          //  mMeeting = null;
        }
    }
}
