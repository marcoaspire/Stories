# Story5
- In this requirement, you need to sort the list of stories based on name, and noOfReads.
-Create a Class Story with the following attributes:


| Member Field Name | Type |
| ----------- | ----------- |
| name      | String |
| authorName   | String |
| genre   | String |
| noOfChapters   | Integer |
| noOfLikes   | Integer |
| noOfReads   | Integer |

- Mark all the attributes as private, Create / Generate appropriate Getters & Setters, Add a default constructor and a parameterized constructor to take in all attributes in the given order: 
**Story( String name, String authorName, String genre, Integer noOfChapters, Integer noOfLikes, Integer noOfReads )**
- Create the following static methods in the Story class


| Method Name | Description |
| ----------- | ----------- |
| static Story createStory(String detail)       | This method accepts a String. The story detail separated by commas is passed as the argument. Split the details and create a story object and returns it.  |

The story details should be given as a comma-separated value in the below order, 
name, authorName, genre, noOfChapters, noOfLikes, noOfReads

- The Story class should implement the Comparable interface which sorts the Story list based on name.While comparing, all the name attributes in the list are unique.
- Create a class NoOfReadsComparator which implements Comparator interface and sort the Story list based on noOfReads. While comparing, all the noOfReads attributes in the list are unique. 

Get the number of Stories and story details and create a story list. Sort the Stories according to the given option and display the list.

Sample Input and Output 1: <br>
Enter the number of the stories: 
4 <br>
who are u to me?,Chatan,Romance,12,4000,4990.<br> 
Hold on,TRTells,Horror,15,3000,3333 <br>
Dark witch,Fanny,Action,8,2000,2759 <br>
Pirate's Life,Lauren,Romance,25,2500,2631<br>
Enter a type to sort: <br>
1.Sort by Name <br>
2.Sort by No. of Reads <br>
2 <br>

| Name | Author Name  | Genre | No. of Chapters  |  No. of Likes  |No. of Reads |
| ----------- | ----------- | ----------- | ----------- | ----------- |----------- |
| Pirate's Life       | Lauren | Romance  |25|2500|2631|
| Dark witch    | Fanny |Action|8|2000|2759|
| Hold on   | TRTells | Horror | 15 | 3000 | 3333|
| noOfChapters   | Integer | Romantic |12|4000|4990|
