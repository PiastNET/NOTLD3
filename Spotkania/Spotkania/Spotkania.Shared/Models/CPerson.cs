using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Diagnostics;

namespace Spotkania.Models
{
    public class CPerson : INotifyPropertyChanged
        {
            private string mName;
            private string mSurname;

        //    [Required(ErrorMessage = "First name is required.")]
            public string Name
            {
                get { return mName; }
                set 
                { 
                    mName = value;
                    OnPropertyChanged();
                }
            }

            public string Surname
            {
                get { return mSurname; }
                set 
                {
                    mSurname = value;
                    OnPropertyChanged();
                }
            }

            public override string ToString()
            {
                string mValueToReturn =
                    "Imie :" + mName +
                    "Nazwisko :" + mSurname;

                return mValueToReturn;
            }
            public CPerson(string aName, string aSurname)
            {
                mName = aName;
                mSurname = aSurname;
                //   mMeeting = aMeeting;
            }

            public CPerson()
            {
                mName = "DefaultName";
                mSurname = "DefaultSurname";
            }

            public event PropertyChangedEventHandler PropertyChanged;
     
            protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                Debug.WriteLine("on property changed");
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
            }
        
    }
}
