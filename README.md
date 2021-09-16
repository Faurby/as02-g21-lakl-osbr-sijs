# Assignment #2

## C&#35;

Fork this repository and implement the code required for the assignments below.

### Extension Methods

Consider the two methods you implemented last week:

```csharp
IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items)

IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate)
```

Given the following collections in scope:

```csharp
IEnumerable<int>[] xs;

int[] ys;
```

Solve the following questions with extension methods (one-liners):

1. Flatten the numbers in `xs`.
2. Select numbers in `ys` which are divisible by `7` and greater than `42`.
3. Select numbers in `ys` which are *leap years*.

Write the answers in the ANSWERS.md file.

Implement and test the following extension methods:

1. A method `IsSecure` which extends `Uri` and returns true if the `Uri` is using *Secure Hypertext Transfer Protocol*.
1. A method `WordCount` which extends `string` and returns the number of words in the string. Note a word can only contain *unicode letters* (no numbers or symbols).

Use the supplied `Extensions.cs` and `ExtensionsTests.cs` files.

### Delegates / Anonymous methods

Implement the following anonymous functions using the built-in delegates and lambda expressions:

1. A method which takes a string and prints the content in reverse order (by character)
1. A method which takes two decimals and returns the product
1. A method which takes a whole number and a string and returns `true` if they are numerically equal. Note that the string `"  0042"` should return true if the number is `42`

Write the answers in the ANSWERS.md file.

You probably want to implement a set of tests to validate the methods.

Use the supplied `DelegatesTests.cs` file.

### LINQ

Prerequisite: Extend the `Wizards.csv` file with at least 10 wizard of your choosing to enable the queries above.
Examine the `Wizard` class and its corresponding unit test class.

Then, given the `Wizard` class:

```csharp
public class Wizard
{
    public string Name { get; set; }

    // Book or film or...
    public string Medium { get; set; }

    public int? Year { get; set; }

    public string Creator { get; set; }

    public static Lazy<IReadOnlyCollection<Wizard>> Wizards { get; } = new Lazy<IReadOnlyCollection<Wizard>>(() =>
    {
        var csv = File.OpenText("../../../../Wizards.csv");
        using (var reader = new CsvReader(csv))
        {
            reader.Configuration.Delimiter = ",";
            return reader.GetRecords<Wizard>().ToList().AsReadOnly();
        }
    });
}
```

Use the supplied `Queries.cs` and corresponding tests class to implement and test the following queries using LINQ:
(You need to wrap the queries in suitable methods for testing)

1. Wizards invented by *Rowling*. Only return the names.
1. The year the first *sith lord* was introduced. Let's define a *sith lord* to be one named Darth *something*.
1. Unique list of wizards from the *Harry Potter* books - only return name and year (as a value tuple).
1. List of wizard names grouped by creator in reverse order by creator name and then wizard name.

Each method *must* be implemented twice - once using only *extension methods* and once using as much *LINQ* as possible.

## Software Engineering

### Exercise 1

What is the difference between a scenario and a use case? When do you use each construct?

### Exercise 2

Draw a use case diagram for a ticket distributor for a train system. The system includes two actors: a traveler, who purchases different types of tickets, and a central computer system, which maintains a reference database for the tariff. Use cases should include: __BuyOneWayTicket__, __BuyWeeklyCard__, __BuyMonthlyCard__, __UpdateTariff__. Also include the following exceptional cases: __Time-Out__ (i.e., traveler took too long to insert the right amount), __TransactionAborted__ (i.e., traveler selected the cancel button without completing the transaction), __DistributorOutOfChange__, and __DistributorOutOfPaper__.

### Exercise 3

Draw a sequence diagram for the warehouseOnFire scenario of Figure 2-21. Include the objects __bob__, __alice__, __john__, __FRIEND__, and instances of other classes you may need. Draw only the first five message sends.

### Exercise 4

This year, the Analysis, Design, and Software Architecture course has re-introduced the group project and the entire process for accessing the exam with regards to the mandatory activities has changed. You have been tasked with drawing a UML diagram to depict the new process.
Looking at the slides from the first lecture, you have found all the information you needed to complete the task. Diligently, you have summarized all of them in the below bullet point list:

- After a student enrolls in the course, four mandatory activities (MA) require completion before being allowed to take the exam:
  - MA1 requires a student to participate to an exam simulation;
  - MA2 requires a student to submit and get approved 5 weekly;
  - MA3 requires a student to participarte to three project reviews;
  - MA4 requires a student to participarte to the project demo.
- Participation to MA1 needs to be confirmed by the teaching team.
- Each weekly activity submission needs to be verified by the teaching team.
- Participation to MA3 needs to be confirmed by the teaching team.
- Participation to MA4 needs to be confirmed by the teaching team.

Note: for the purpose of this task you must assume the following:

- The re-execution of mandatory activities must not be modelled. For instance, failing to participate to the exam simulation would require a student to take the second run of such activity. You must not model this detail.
- The number of Weekly activities can be arbitrary.
- Responsibility for the execution of activities must be modelled.
- No time constrain must be included, hence, a student could spent a lifetime completing the mandatory activities and project reviews before being accepted to the exam.

### Exercise 5

Using the solution for Exercise 4 and making use of event-based action (see below), include the process that describes:

- the teaching team sending the exam results to study administration (SAP);
- SAP registering the exams in the system;
- the students verifying their exam grade.

#### Event-based actions (from Section 7.2.1 in [1])

Event-based actions enable objects and signals to be transmitted to receiver objects. They allow you to distinguish between different types of events. You can use an __accept event action__ to model an action that waits for the occurrence of a specific event. The notation element for an accept event action is a "concave pentagon"---a rectangle with a tip that points inwards from the left. If the event is a time-based event, you can use an __accept time event action__, whereby in this case, the notation is an hourglass.

To send signals, you can use __send signal actions__. Send signal actions are denoted with a "convex pentagon"---a rectangle with a tip that protrudes to the right.

![Event Based Actions](EventBasedActions.png "Event Based Actions")

[1] Seidl, Martina, Marion Scholz, Christian Huemer, and Gerti Kappel. UML@ classroom: An introduction to object-oriented modeling. Springer, 2015.

## Submitting the assignment

To submit the assignment you need to create a .pdf document using LaTeX containing the answers to the questions and a link to a public repository containing your fork of the completed code.

Members of the triplets should submit the same PDF file to pass the assignments (Note: This does not cover the name of the pdf, which can differ).  Make sure all group names and ID are clearly marked on the front page.
