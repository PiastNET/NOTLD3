// TheLastChanceCPP.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "Person.h"

using namespace std;

void main()
{
	const int mAmountOfPersons = 3;

	CPerson tempPerson;
	
	CPerson mPerson[mAmountOfPersons];

	
	cout << "Witam w aplikacji organizujacej spotkania" << endl;
	cout << "Z tego co wiedziałem wcześniej zaprosisz " << mAmountOfPersons << " gosci " << endl;
	
	for (int i = 0; i < mAmountOfPersons; i++)
	{
		cout << "Podaj imie goscia numer: " << i + 1 << endl;
		string tempStringOfName="";
		cin >> tempStringOfName;
		tempPerson.setName(tempStringOfName);
	
		cout << "Podaj nazwisko goscia numer: " << i + 1 << endl;
		string tempStringOfSurname = "";
		cin >> tempStringOfSurname;
		tempPerson.setSurname(tempStringOfSurname);
	
		cout << "Podaj miejsce spotkania numer : " << i + 1 << endl;
		string tempStringOfPlace = "";
		cin >> tempStringOfPlace;
		tempPerson.setPlaceOfMeeting(tempStringOfPlace);
	
		cout << "Podaj date spotkanie ( w formacie Dzien//Miesiac//Rok goscia numer: " << i + 1 << endl<<endl;
		string tempStringOfDate = "";
		cin >> tempStringOfDate;
		tempPerson.setDateOfMeeting(tempStringOfDate);
	
		cout << endl;
		mPerson[i] = tempPerson;
	}
	
	cout << "Spotkasz się z ";
	for (int i = 0; i < mAmountOfPersons
		; i++)
	{
		cout << "Imie : " << i << " osoby : "<< mPerson[i].getName() << endl;
		cout << "Nazwisko : " << i << " osoby : " << mPerson[i].getSurname() << endl;
		cout << "Miejsce spotkania " << i << " osoby : " << mPerson[i].getPlaceOfMeeting() << endl;
		cout << "Data spotkania : " << i << " osoby : " << mPerson[i].getDateOfMeeting() << endl;
		cout << endl;
	}

	system("Pause");
}

