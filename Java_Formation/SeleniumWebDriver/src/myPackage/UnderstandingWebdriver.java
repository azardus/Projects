package myPackage;


//import org.openqa.selenium;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;

public class UnderstandingWebdriver {

	public static void main(String[] args) {

		System.setProperty("webdriver.chrome.driver","C:\\WebDriver\\chromedriver_win32\\chromedriver.exe");
		WebDriver driver = new ChromeDriver();
		
		driver.get("https://google.com/");
		WebElement searchField = driver.findElement(By.name("q"));
		searchField.sendKeys("pluralsight");
		searchField.submit();
		
		WebElement imagesLink = driver.findElements(By.linkText("Images")).get(0);
		imagesLink.click();
		
		WebElement imageElement = driver.findElement(By.cssSelector("#islrg > div.islrc > div:nth-child(2) > a.wXeWr.islib.nfEiy.mM5pbd > div.bRMDJf.islir > img"));
		imageElement.click();
	}

}
