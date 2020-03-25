package myPackage;

import org.openqa.selenium.*;
import org.openqa.selenium.chrome.*;
//import org.openqa.selenium.;
//import org.openqa.selenium.firefox.*;


public class MyClass {
	// guru99.com/first-webdriver-script.html
	
	
	
	  public static void main(String[] args) {
		  //comment the above 2 lines and uncomment below 2 lines to use firefox
//	    	System.setProperty("webdriver.firefox.marionette","C:\\geckodriver.exe");
//	    	WebDriver driver = new FirefoxDriver();

		  		  	System.getProperties();
			
		  		  	// declaration and instantiation of objects/variables
			System.setProperty("webdriver.chrome.driver","C:\\Users\\jpi\\Downloads\\chromedriver_win32\\chromedriver.exe");
			WebDriver driver = new ChromeDriver();
	    	
	        String baseUrl = "http://demo.guru99.com/test/newtours/";
	        String expectedTitle = "Welcome: Mercury Tours";
	        String actualTitle = "";

	        // launch Fire fox and direct it to the Base URL
	        driver.get(baseUrl);
	        driver.manage();

	        // get the actual value of the title
	        actualTitle = driver.getTitle();
	        driver.getWindowHandle();
	        
	        String tagName= "navbar-brand-centered";
	        String idText= "navbar-brand-centered";
	        String className = "dropdown-toggle";
	        className = driver.findElement(By.className(className)).getTagName();
	        System.out.println(className);
	        
	        tagName = driver.findElement(By.id(tagName)).getTagName();
	        idText = driver.findElement(By.id(idText)).getCssValue("border-color");
	        System.out.println(idText);
	        

	        /*
	         * compare the actual title of the page with the expected one and print
	         * the result as "Passed" or "Failed"
	         */
	        if (actualTitle.contentEquals(expectedTitle)){
	            System.out.println("Test Passed!");
	        } else {
	            System.out.println("Test Failed");
	        }
	        

	       
	        //close chrome
//	        driver.close();
	    }

}
