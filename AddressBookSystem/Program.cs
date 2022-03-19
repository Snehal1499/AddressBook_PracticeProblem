using System;
using System.Collections;

namespace AddressBookSystem
{
    public class AddressBook
    {
        public string FirstName, FirstName2, LastName, LastName2, Address, Address2, City, City2, State, State2, Zip, Zip2, PhoneNumber, PhoneNumber2, Email, Email2;
        public int value;
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome To Address Book Program");
                AddressBook a = new AddressBook();
                ArrayList addbook = new ArrayList();
                choice();
                void choice()
                {
                    Console.WriteLine("\nEnter 1 to Add Details");
                    Console.WriteLine("Enter 2 to Add 2nd Person Details");
                    Console.WriteLine("Enter 3 to Edit Existing Detail");
                    a.value = Convert.ToInt32(Console.ReadLine());
                    switch (a.value)
                    {
                        case 1:

                            Console.WriteLine("Enter First Name ");
                            a.FirstName = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.FirstName);
                            Console.WriteLine("Enter Last Name");
                            a.LastName = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.LastName);
                            Console.WriteLine("Enter Address ");
                            a.Address = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.Address);
                            Console.WriteLine("Enter city");
                            a.City = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.City);
                            Console.WriteLine("Enter state");
                            a.State = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.State);
                            Console.WriteLine("Enter zip");
                            a.Zip = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.Zip);
                            Console.WriteLine("Enter Phone Number");
                            a.PhoneNumber = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.PhoneNumber);
                            Console.WriteLine("Enter Email");
                            a.Email = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.Email);

                            Console.WriteLine("\nGiven Detail Are : \n");
                            Console.WriteLine("First Name = " + addbook[0]);
                            Console.WriteLine("Lastt Name = " + addbook[1]);
                            Console.WriteLine("Address = " + addbook[2]);
                            Console.WriteLine("City = " + addbook[3]);
                            Console.WriteLine("State = " + addbook[4]);
                            Console.WriteLine("Zip = " + addbook[5]);
                            Console.WriteLine("Phone Number = " + addbook[6]);
                            Console.WriteLine("Email = " + addbook[7]);
                            break;
                        case 2:
                            Console.WriteLine("Enter First Name ");
                            a.FirstName2 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.FirstName2);
                            Console.WriteLine("Enter Last Name");
                            a.LastName2 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.LastName2);
                            Console.WriteLine("Enter Address ");
                            a.Address2 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.Address2);
                            Console.WriteLine("Enter city");
                            a.City = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.City2);
                            Console.WriteLine("Enter state");
                            a.State2 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.State2);
                            Console.WriteLine("Enter zip");
                            a.Zip2 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.Zip2);
                            Console.WriteLine("Enter Phone Number");
                            a.PhoneNumber2 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.PhoneNumber2);
                            Console.WriteLine("Enter Email");
                            a.Email2 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.Email2);

                            Console.WriteLine("\nGiven new Details Are : \n");
                            Console.WriteLine("First Name = " + addbook[8]);
                            Console.WriteLine("Lastt Name = " + addbook[9]);
                            Console.WriteLine("Address = " + addbook[10]);
                            Console.WriteLine("City = " + addbook[11]);
                            Console.WriteLine("State = " + addbook[12]);
                            Console.WriteLine("Zip = " + addbook[13]);
                            Console.WriteLine("Phone Number = " + addbook[14]);
                            Console.WriteLine("Email = " + addbook[15]);
                            break;
                        case 3:
                            Console.WriteLine("Enter the First Name and Last Name of that Person");
                            string fname = Convert.ToString(Console.ReadLine());
                            string lname = Convert.ToString(Console.ReadLine());

                            if ((a.FirstName == fname) && (a.LastName == lname))
                            {
                                Console.WriteLine("Enter First Name ");
                                a.FirstName = Convert.ToString(Console.ReadLine());
                                addbook.Add(a.FirstName);
                                Console.WriteLine("Enter Last Name");
                                a.LastName = Convert.ToString(Console.ReadLine());
                                addbook.Add(a.LastName);
                                Console.WriteLine("Enter Address ");
                                a.Address = Convert.ToString(Console.ReadLine());
                                addbook.Add(a.Address);
                                Console.WriteLine("Enter city");
                                a.City = Convert.ToString(Console.ReadLine());
                                addbook.Add(a.City);
                                Console.WriteLine("Enter state");
                                a.State = Convert.ToString(Console.ReadLine());
                                addbook.Add(a.State);
                                Console.WriteLine("Enter zip");
                                a.Zip = Convert.ToString(Console.ReadLine());
                                addbook.Add(a.Zip);
                                Console.WriteLine("Enter Phone Number");
                                a.PhoneNumber = Convert.ToString(Console.ReadLine());
                                addbook.Add(a.PhoneNumber);
                                Console.WriteLine("Enter Email");
                                a.Email = Convert.ToString(Console.ReadLine());
                                addbook.Add(a.Email);
                                Console.WriteLine("\nGiven new Details Are : \n");
                                Console.WriteLine("First Name = " + addbook[0]);
                                Console.WriteLine("Lastt Name = " + addbook[1]);
                                Console.WriteLine("Address = " + addbook[2]);
                                Console.WriteLine("City = " + addbook[3]);
                                Console.WriteLine("State = " + addbook[4]);
                                Console.WriteLine("Zip = " + addbook[5]);
                                Console.WriteLine("Phone Number = " + addbook[6]);
                                Console.WriteLine("Email = " + addbook[7]);
                            }
                            else if ((a.FirstName2 == fname) && (a.LastName2 == lname))
                            {
                                Console.WriteLine("Enter First Name ");
                                a.FirstName2 = Convert.ToString(Console.ReadLine());
                                addbook.Add(a.FirstName2);
                                Console.WriteLine("Enter Last Name");
                                a.LastName2 = Convert.ToString(Console.ReadLine());
                                addbook.Add(a.LastName2);
                                Console.WriteLine("Enter Address ");
                                a.Address2 = Convert.ToString(Console.ReadLine());
                                addbook.Add(a.Address2);
                                Console.WriteLine("Enter city");
                                a.City = Convert.ToString(Console.ReadLine());
                                addbook.Add(a.City2);
                                Console.WriteLine("Enter state");
                                a.State2 = Convert.ToString(Console.ReadLine());
                                addbook.Add(a.State2);
                                Console.WriteLine("Enter zip");
                                a.Zip2 = Convert.ToString(Console.ReadLine());
                                addbook.Add(a.Zip2);
                                Console.WriteLine("Enter Phone Number");
                                a.PhoneNumber2 = Convert.ToString(Console.ReadLine());
                                addbook.Add(a.PhoneNumber2);
                                Console.WriteLine("Enter Email");
                                a.Email2 = Convert.ToString(Console.ReadLine());
                                addbook.Add(a.Email2);

                                Console.WriteLine("\nGiven new Details Are : \n");
                                Console.WriteLine("First Name = " + addbook[8]);
                                Console.WriteLine("Lastt Name = " + addbook[9]);
                                Console.WriteLine("Address = " + addbook[10]);
                                Console.WriteLine("City = " + addbook[11]);
                                Console.WriteLine("State = " + addbook[12]);
                                Console.WriteLine("Zip = " + addbook[13]);
                                Console.WriteLine("Phone Number = " + addbook[14]);
                                Console.WriteLine("Email = " + addbook[15]);
                            }
                            break;
                        case 4:
                            Console.WriteLine("Enter First Name and Last Name of the person to delete his record");
                            string fname1 = Convert.ToString(Console.ReadLine());
                            string lname2 = Convert.ToString(Console.ReadLine());
                            if ((a.FirstName == fname1) && (a.LastName == lname2))
                            {
                                addbook.RemoveRange(0, 7);

                                Console.WriteLine("\n Record Deleted: \n");

                            }
                            else if ((a.FirstName2 == fname1) && (a.LastName2 == lname2))
                            {
                                addbook.RemoveRange(8, 15);
                                Console.WriteLine("\n Record Deleted: \n");

                            }
                            break;
                    }
                    choice();
                }
            }
        }
    }
}













