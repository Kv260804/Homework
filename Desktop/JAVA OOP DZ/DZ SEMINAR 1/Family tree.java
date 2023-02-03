public class Family {
    private String familyName;
    private String firstName;
    private int age;
    private String birthday;

    Family(String familyName, String firstName, int age, String birthday) {
        this.age = age;
        this.familyName = familyName;
        this.firstName = firstName;
        this.birthday = birthday;
    }

    Family() {
        this.age = 0;
    }

    public String getFamilyName() {
        return familyName;
    }

    public String getFirstName() {
        return firstName;
    }

    public String getBirthday() {
        return birthday;
    }

    public int getAge() {
        return age;
    }

    public void setFamilyName(String familyName) {
        this.familyName = familyName;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public void setBirthday(String birthday) {
        this.birthday = birthday;
    }


    public void showInfo() {
        System.out.println("Family: " + familyName);
        System.out.println("Name: " + firstName);
        System.out.println("Age: " + age);
        System.out.println("Birthday: " + birthday);
    }
}

class Relative extends Family {
    private String relativeStatus;
    String parents;
    String children;

    public String getRelativeStatus() {
        return relativeStatus;
    }

    public void setRelativeStatus(String relativeStatus) {
        this.relativeStatus = relativeStatus;
    }


    Relative(String s) {
        super();
        setRelativeStatus(s);
    }

    Relative(String s, String famN, String firstN, int age, String birth) {
        super(famN, firstN, age, birth);
        setRelativeStatus(s);
    }

    void showStatus() {
        System.out.println("Relative status: " + relativeStatus);
    }


}

class FamilyTree {
    public static void main(String[] args) {
        Relative p1 = new Relative("Отец", "Куделин", "Алексей", 41, "26.01.1982");
        Relative p2 = new Relative("Мать", "Веселова", "Марина", 40, "30.07.1982");
        Relative s1= new Relative("Сын","Веселов","Константин",18,"26.08.2004");
        Relative s2= new Relative("Дочь","Веселова","Варя",12,"15.01.2011");



        p1.showStatus();
        p1.showInfo();
        System.out.println("===========================");
        p2.showStatus();
        p2.showInfo();
        System.out.println("===========================");
        s1.showStatus();
        s1.showInfo();
        System.out.println("===========================");
        s2.showStatus();
        s2.showInfo();



    }
}