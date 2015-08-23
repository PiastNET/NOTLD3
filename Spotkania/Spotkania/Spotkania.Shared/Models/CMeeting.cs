using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Diagnostics;


namespace Spotkania.Models
{
        class CMeetings : INotifyPropertyChanged
        {
            // trzeba dodac numery do osób
            // trzeba dodać możliwyBudżet imprezy
            // 
            private CPerson mInviter;
            private string mName { get; set; }
            private List<CPerson> mListOfPersonToInvite { get; set; }
         //   private MapAddress mLocation { get; set; }
            private DateTime mDateOfMeetings { get; set; }


            public void setInviter(CPerson aInviterPerson)
            {
                if (mInviter != aInviterPerson)
                {
                    mInviter = aInviterPerson;
                    OnPropertyChanged();
                }
            }

            public CPerson getInviter()
            {
                return mInviter;
            }

            public void Invite(CPerson aPersonToAdd)
            {
                mListOfPersonToInvite.Add(aPersonToAdd);
                OnPropertyChanged();
            }

            // GETTERY
            public List<CPerson> getListOfPerson()
            {
                return mListOfPersonToInvite;
            }
            public DateTime getDateOfMeetings()
            {
                return mDateOfMeetings;
            }
            public string getName()
            {
                return mName;
            }

            // SETTERY
            public void SetName(string aName)
            {
                mName = aName;
                OnPropertyChanged();
               //   mName != NULL ? Debug.WriteLine("Dodałem date") : Debug.WriteLine("Nie dodałem osobe"); ;
                // return mValueToReturn;
            }
            public void SetDate(DateTime aDateOfMeetings)
            {

                mDateOfMeetings = aDateOfMeetings;

                OnPropertyChanged();
            }
                
            
        //  public void SetPersons(List<CPerson> aListOfPerson)
        //  {
        //      mListOfPersonToInvite = aListOfPerson;
        //  }
        //

            public event PropertyChangedEventHandler PropertyChanged;



            public CMeetings(CPerson aInviter, string aName, DateTime aDateTime/* List<CPerson> aListOfPersonToInvite*/)
            {
                //  SetOrganizator(aInviter);
                SetName(aName);
                
                SetDate(aDateTime);
               // SetPersons(aListOfPersonToInvite);
            }

            public CMeetings()
            {
                //  SetOrganizator(null);
                SetName("");
                
                SetDate(DateTime.MinValue);
               // SetPersons(null);
                setInviter(null);
            }

            protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChangedEventHandler handler = PropertyChanged;
                //System.Diagnostics.Debug("Zmienilem Pole w Meetings");
                if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
            }
        
    }
}
