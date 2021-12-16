Implementation:
The implementation for current project includes four major components. These components are given below:
	1. Visual Studio: It is used as a IDE for doing the automation code and creating hierarchy. This is same as the PyCharm, Eclipse and other IDEs.
	2. Specflow: It is an extension for BDD same as Cucumber. It binds BDDs with the respective step definitions. Specflow is used with C#. 
	3. Selenium: It is used for the Web Automation/Web Testing.
	4. CSharp (C#): Programming language used with Selenium.
Below is the directory hierarchy of the project:
	1. Business Logic: This contains the code files for the automation integrated with Selenium.
	2. Commons: This contains the common functions.
	3. Features: This contains all the feature files.
	4. Page Object Models: This contains the files and functions related to the Page Object Model (POM).
	5. Step Definitions: This contains the definitions of steps which are in feature files.

Advantages of BDD Approach:
	1. Plain text scenarios mean we can involve business stakeholders who can't easily read code.
	2. It focused on user experience (Customer Centric).
	3. Style of writing tests allow for easier reuse of code in the tests.
	4. Quick and easy setup and execution.
	5. Tag based execution.

Tools & Configurations:
	1. IDE: Visual Studio
	2. Plugins: Specflow
	3. Language: C#
	4. Automation Tool: Selenium
	5. Framework: Dot Net

You need to complete the following steps before running the solution:
	1. Go to the URL https://visualstudio.microsoft.com/downloads/
	2. Download and Install the Visual Studio 2022 Community Version by selecting following:
		i. ASP.net and Web Development
	3. Launch Visual Studio.
	4. Open Extensions -> Manage Extensions.
	5. Search for Specflow and install it.
	6. Close the Visual Studio and Open again.
	7. Open the project solution.
	8. Now install the following dependencies by opening View -> Other Windows -> Package Manager Console.
		i. Install-Package Selenium.WebDriver
		ii. Install-Package Selenium.WebDriver.ChromeDriver
		iii. Install-Package Selenium.WebDriver.GeckoDriver
		iv. Install-Package Selenium.WebDriver.IEDriver
	9. Open Test Explorer by clicking Test in the Top Navigation.
	10. Execute all or specific tests from Test Explorer.