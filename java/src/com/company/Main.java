package com.company;

import java.util.*;

class Person
{
    private String  name;
    private int age;

    public Person(String name)
    {
        this.name = name;
    }

    public String getName() {
        return name;
    }

    public int getAge() {
        return age;
    }
}

class PersonComparer implements Comparator<Person>
{
    @Override
    public int compare(Person o1, Person o2) {
        return o1.getName().compareTo(o2.getName());
    }
}

public class Main {

    public static void main(String[] args) {
	// write your code here

        Person person1 = new Person("Tom Brady");
        Person person2 = new Person("David Letterman");

        List<Person> personList = new ArrayList<Person>();
        personList.add(person1);
        personList.add(person2);

        // Sorting
        // Collections.sort(personList, new PersonComparer());
        // Collections.sort(personList, (o1, o2) -> o1.getName().compareTo(o2.getName()));
        personList.sort((o1, o2) -> o1.getName().compareTo(o2.getName()));

        // Print out the people!
        for (Person p : personList)
        {
            System.out.println(p.getName());
        }

    }
}
