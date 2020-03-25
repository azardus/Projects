
import java.util.List;
import java.util.concurrent.TimeUnit;

import org.openqa.selenium.By;
import org.openqa.selenium.Keys;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;

public class Eiqc {

	public static void main(String[] args) {
		
		  	System.getProperties();
			
  		  	// declaration and instantiation of objects/variables
		  	System.setProperty("webdriver.chrome.driver","C:\\Users\\jpi\\Downloads\\chromedriver_win32\\chromedriver.exe");
		  	
		  	// Creating instance of Chrome
		  	WebDriver driver = new ChromeDriver();

		  	// URL
		  	String baseUrl = "https://valid-hema.myexpertqc.com/";
		  	
		  	// Navigate to url
		  	driver.navigate().to(baseUrl);
		  	
		 // Creating an instance of NgWebDriver
//		  	NgWebDriver ngdriver = new NgWebDriver((JavascriptExecutor) driver);

		  	// Waiting for Angular to finish async activity

	        driver.manage().timeouts().implicitlyWait(40, TimeUnit.SECONDS);
	        
		  	// Creating path of button login
//		  	WebElement login = driver.findElement(By.cssSelector("#menu5 > a"));
//		  	driver.findElement(By.className("a.button-login gradation-light-blue")).click();
		  	driver.findElement(By.cssSelector("#menu5 > a")).click();
//		  	WebElement login = driver.findElement(By.className("button-login gradation-light-blue"));
//		  	login.click();
		  	
		  	
		  	// click on Login
//		  	((JavascriptExecutor) driver).executeScript("arguments[0].click();", login);
		  	
	
		  	// Xpath selector button login
//		  	WebElement eleXpath = driver.findElement(By.xpath("//*[@id=\"menu5\"]/a"));
		  	
		  	
//		    WebElement login = driver.findElement(ByCssSelector.cssSelector("#loginPage > form > div.modal-body > div:nth-child(2) > input"));
//		    login.click();
//			JavascriptExecutor jse = (JavascriptExecutor).driver;
//		  	jse.executeScript("document.getElementsByName('email')[0].click()");
		  	
//		  	driver.findElement(By.name("email")).sendKeys("KatalonLab3_Test355");
//		  	driver.findElement(ByAngular.model("vm.userName")).sendKeys("KatalonLab3_Test355");
		  //*[@id="loginPage"]/form/div[1]/div[2]/input
		  	
//		  	int testnumber = 355;
		  	String coag = "KatalonLab1Test_371@yopmail.com";

		  	// Login
//		  	driver.findElement(By.cssSelector("#loginPage > form > div.modal-body > div:nth-child(2) > input")).sendKeys("KatalonLab3Test_" + testnumber + "@yopmail.com");   ///ok\\\
//		  	driver.findElement(By.className(name ="email")).sendKeys("KatalonLab3Test_" + testnumber + "@yopmail.com");

		  	driver.findElement(By.cssSelector("#loginPage > form > div.modal-body > div:nth-child(2) > input")).sendKeys(coag);
			
		  	// Password  	
		  	driver.findElement(By.name("password")).sendKeys("Password123!" + Keys.ENTER);
		  	
		  	// Data manager
		  	driver.findElement(By.cssSelector("#navbar > li:nth-child(2) > ol > li:nth-child(1) > a")).click();
		  	
		  	// Select input Instruments
		  	driver.findElement(By.cssSelector("#filter-section > div:nth-child(3) > div > div > div:nth-child(1) > input")).click();
		  	// .sendKeys("Hema 2000 (InstruSN371)" + Keys.ENTER)
		  	
		  	// Select instruments Hema 2000 (InstruSN371)
//		  	driver.findElement(By.cssSelector("")).click();
		  	
		  	// Laboritory
//		  	driver.findElement(By.cssSelector("#header-buttons-left > button:nth-child(2)")).click();		/// ok \\\
		  	
		  	// Input name of labo
		  	
//		  	String labo = "KatalonLab3_Test356";
		  	List <WebElement> inputs = driver.findElements(By.tagName("input"));
		  	for( int i=0, c = inputs.size(); i<c; i++) {
		  		System.out.print( "input n°" + i + ':' + inputs.get(i) );
		  	}
	  	
		  	System.out.print(true);
	
	}

}
