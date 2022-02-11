# Story1
- Create a User Class with the following attributes: 

| Member Field Name | Type |
| ----------- | ----------- |
| username      | String |
| mailId   | String |
| password   | String |

- Mark all the attributes as private 
- Create / Generate appropriate Getters & Setters 
- Add a parameterized constructor to take in all attributes in the given order:  
  User ( String username, String mailId, String password ) 
- When the “User” object is printed, it should display the following details: [Override the toString method] 
Print format: 
Username:"username" 
Mail Id:"mailId" 
Password:"password" 
-The input format consists of User details separated by comma in the below order, 
username, mailId, password

The Input to your program would be details of two Users, you need to display their details as given in "5th point(refer above)" and compare the two Users and display if the Users are same or different.

Note: There is an empty line between display statements. Print the empty lines in main function. 


Sample Input & Output 1: 
 
Enter user 1 details: 
Harry,harry@gmail.com,harry123 
Enter user 2 details: 
Harry,harry@gmail.com,harry123 
 
User 1 
Username:Harry 
Mail Id:harry@gmail.com 
Password:harry123 
 
User 2 
Username:Harry 
Mail Id:harry@gmail.com 
Password:harry123 
 
User 1 is same as User 2 
 
Sample Input & Output 2: 
 
 
Enter user 1 details: 
Harry,harry@gmail.com,harry123 
Enter user 2 details: 
Joe,joe@gmail.com,joe@100 
 
User 1 
Username:Harry 
Mail Id:harry@gmail.com 
Password:harry123 
 
User 2 
Username:Joe 
Mail Id:joe@gmail.com 
Password:joe@100 
 
User 1 and User 2 are different 

