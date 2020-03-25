import java.util.Date;
import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.LocalTime;
import java.time.Month;

public class Variable {

	// Variable d'instance : can't be used in main, if they are not static//
	//	A static variable is common to all the instances (or objects) of the class because it is a class level variable
	byte aByte = 127;
	float b = -11.43F;
	long c = 9_123_456_789L;
	int typeValeur1 = 1;
	
	// Variable de classe //
	static int age = 41;
	static int agePremierJumeau = 25;
	static int ageSecondJumeau = agePremierJumeau;
	static String _jeremie = "Jeremie";
	static String _mimi = "Mimi";
	static String _antoine = "Antoine";
	
	
	public class Name{

		protected static Namejeremie;
	
		public static Name getJeremie() {return Name.jeremie};
		
		static Name name = new Name();
		static Name name2 = jeremie;
	}
	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		boolean ComparaisonValueOfNameClass = Name.name2.equals(jeremie);
		System.out.println(ComparaisonValueOfNameClass);
		
		System.out.println("1- les variables");
		System.out.println("----------------");
		
//		Error car the field abyte isn't static
//		--------------------------------------
//		System.out.println(aByte);
//		aByte.equal(age);
		System.out.println(age);
		
		// Variable local //
		int age = Variable.age;
		int addAge = age +1 ;

		System.out.println(addAge);
		System.out.println(agePremierJumeau);
		System.out.println(ageSecondJumeau);

		System.out.println();		
		System.out.println("2- Utilisation des date avec l'import java.util.Date");
		System.out.println("----------------------------------------------------");		
		
		Date d1 = new Date();
		Date d2 = d1;
		System.out.println(d2);
		

		System.out.println();
		System.out.println("3- Comparaison de 2 chaine de caracteres:");
		System.out.println("-----------------------------------------");
		
		Object value = _jeremie.equals(_mimi);
		System.out.println(value);
		
		_jeremie.equalsIgnoreCase(_antoine);
		Object value2 = _jeremie.equals("Jeremie");
		System.out.println(value2);
		
		_jeremie.contentEquals("Jeremie");
		

		System.out.println();
		System.out.println("4- Utilisation de date avec l'import de java.time.LocalDate et java.time.LocalDateTime:");
		System.out.println("---------------------------------------------------------------------------------------");
		
		LocalDate noel;
		noel = LocalDate.of(2019, 12, 25);
		System.out.println("Noel: "+ noel);
		
		

		  LocalDateTime currentTime = LocalDateTime.now();
			
		  LocalDate date1 = currentTime.toLocalDate();
	      System.out.println("Date courante : " + date1);
			
	      Month mois = currentTime.getMonth();
	      int jour = currentTime.getDayOfMonth();
	      int heure = currentTime.getHour();
			
	      System.out.println("Mois : " + mois +", jour : " + jour +", heure : " + heure);
		
	      //Avoir le 25 d�cembre 2023
	      LocalDateTime date2 = currentTime.withDayOfMonth(25).withYear(2023).withMonth(12);
	      System.out.println("Date modifi�e : " + date2);
			
	      //une autre fa�on
	      LocalDate date3 = LocalDate.of(2023, Month.DECEMBER, 25);
	      System.out.println("Autre fa�on de faire : " + date3);
			
	      //On peut m�me parser une date depuis un String
	      LocalTime parsed = LocalTime.parse("20:15:30");
	      System.out.println("Date pars�e : " + parsed);
		
		
	}
	
}

