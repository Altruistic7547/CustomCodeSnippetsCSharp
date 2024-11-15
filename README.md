# Snippets Enjoyments in Visual Studio

## Why to enjoy Snippets?

Snippets are powerful tools in Visual Studio that allow you to automate and speed up your coding process. They are small pieces of reusable code that can be inserted into your editor with just a few keystrokes. Major benefit is it saves time in long run for production projects and pretty handy if you can leverage it for repetitive work that needs to be done within the timeline.

Using snippets is a way to:
- **Increase productivity**: Write less and let you focus on what you actually need to do!
- **Reduce errors**: No more copying and pasting repetitive code. Snippets help you maintain consistency and avoid errors while doing repetitive code.
- **Enforce best practices**: By using predefined templates, you ensure that your code follows best practices and conventions throughout your organization.
- **Saves time**: Reuse common patterns in your development process without needing to remember all the syntax or code.

## How to Enjoy Snippets in Visual Studio

### 1. **Install and Use Snippets in Visual Studio**
To make use of snippets in Visual Studio, follow these steps:

1. **Create Your Own Snippets**:
   - Go to the "Tools" menu, select **Code Snippets Manager** (or use `Ctrl + K, Ctrl + B`).
   - You can create a new snippet or import existing ones.
   - Alternatively, you can create `.snippet` files manually and place them in the appropriate folder for your Visual Studio environment (e.g., `Documents\Visual Studio <version>\Code Snippets`).

2. **Trigger Snippets**:
   - Type the snippet's shortcut keyword (e.g., `ae`, `ae0`, `ain`).
   - Press `Tab` to expand the snippet into your code.
   - Customize the snippet further by filling in the placeholders or adjusting parameters.

3. **Manage Your Snippets**:
   - You can modify or remove your custom snippets by editing the `.snippet` files or through the Code Snippets Manager.
   - Snippets can be organized into different categories for easier access and management.
   - Enjoy!

### 2. **Predefined Shortcuts in Visual Studio**:
   - **`Ctrl + K, Ctrl + X`**: Displays the list of available snippets for the current language.
   - **`Ctrl + K, Ctrl + I`**: Displays a list of code actions (including snippets) relevant to the current cursor location.

## What More We Can Do with Snippets?

The possibilities with snippets are mind blowing if you really dive into it!!:

- **Advanced Conditional Snippets**: You can create snippets that take in conditional logic or parameters, making them context-aware and adaptable.
- **Snippet Templates with XML Documentation**: You can generate code snippets that automatically include XML documentation for your functions and properties.
- **Custom Snippets for Specific Use Cases**: Whether it's for **Unit Testing**, **LINQ Operations**, or **ASP.NET API development**, custom snippets can save a lot of time by auto-generating boilerplate code.
- **Enhance enjoyment with T4 Templates(Snippents on steroids!!!)**: Combine snippets with **T4 templates** to generate complex code structures based on your needs, and you will get classes, DTOs, or even FluentValidation code as per your needs.
- **Enjoyment with Task/Code Managers**: Snippets can be tied to tasks or management tools like Jira or GitHub Issues to automate common patterns associated with tickets or user stories.


## Leveraging T4 templates

T4 (Text Template Transformation Toolkit) is a powerful tool for generating code or any text-based files in Visual Studio. T4 templates allow you to automate the process of creating repetitive files or structures, making your development workflow faster and more efficient. With T4, you can generate **C# classes**, **DTOs**, **Validation rules**, **FluentValidation**, **API code**, or any other text-based content directly from your templates.

### How to Use T4 Templates in Visual Studio?

1. **Add a T4 Template**:
   - Right-click on your project > Add > New Item.
   - Search for **Text Template** and select **Text Template**.
   - This will add a `.tt` file to your project. You can then write custom code in the template to generate files based on your needs.

2. **Run the T4 Template**:
   - When you save the `.tt` file, Visual Studio automatically runs the T4 engine, which generates the output based on the logic written inside the template.
   - You can reference variables, collections, or any logic you need to dynamically generate content.

   - Alternatively, Open **Developer Command Prompt for Visual Studio**, navigate to the folder you have stored your `.tt` file 
	- command is `TextTransform.exe YourTemplateFile.tt`
	- Enjoy!
## Table of Snippets I Made

Here's a list of the **snippets** we've created to enhance your development experience:

| **Category**               | **Snippet**               | **Description**                                      |
|----------------------------|---------------------------|------------------------------------------------------|
| **Unit Testing (MSTest)**  | ae                      | Assert.AreEqual with T                             |
|                            | ane                     | Assert is not equal with choice of T                |
|                            | ae0                     | Assert.AreEqual to 0                               |
|                            | afa                     | Assert.Fail()                                      |
|                            | an                      | Assert is null                                     |
|                            | ann                     | Assert is not null                                 |
| **LINQ**				     | linqselect                  | LINQ Select - Projecting Data                      |
|                            | linqwhere                   | LINQ Where - Filtering Data                        |
|                            | linqorderby                 | LINQ OrderBy - Sorting Data                        |
|                            | linqgroupby                 | LINQ GroupBy - Grouping Data                       |
| **Others**                 | mappd              | Inserts the readonly automapper field              |
|                            | utm                     | Creates a unit test method for MSTest                               |
| **Properties**             | dprop				   | Generates a property with proper xml comment		  |
|                            | rdprop                  | Genrates a required property with xml comment        |
|                            | vdprop                  | Genrates a property with xml comment and give value  |
|                            | slprop				   | Genrates a string property with maximum string length|
| **T4 Templates**           | GenerateDTO  | Use to generate a DTO class with specified properties and XML comments|
|							| GenerateFluentValidationValidator| Use to generate a validation class using FluentValidation|
|							| DTOAndDataModels| Use to generate both data model and data transfer object(DTO) based on given class name and property metadata(property type and property name)|
|							| BulkDTOAndDataModels| Use to generate multiple data model and data transfer object(DTO) based on given class name and property metadata(property type and property name)|

feel free to look at the source files containing snippets and t4 template filein this repository!!

## Resources I have enjoyed
- [Understand and use code snippets - Visual Studio (Windows)](https://learn.microsoft.com/en-us/visualstudio/ide/code-snippets?view=vs-2022)
- [Walkthrough: Create a code snippet in Visual Studio](https://learn.microsoft.com/en-us/visualstudio/ide/walkthrough-creating-a-code-snippet?view=vs-2022)
- [Creating custom code snippets in Visual Studio - Medium](https://medium.com/c-sharp-programming/creating-custom-code-snippets-in-visual-studio-68c1c88ab8b8)
- [Code Generation and T4 Text Templates](https://learn.microsoft.com/en-us/visualstudio/modeling/code-generation-and-t4-text-templates?view=vs-2022)
- [Best practices for working with T4 Templates in Visual Studio](https://medium.com/@timmaes/best-practices-for-working-with-t4-templates-in-visual-studio-09eed730af1e)

## Concluding

Leveraging **snippets** in Visual Studio not only makes you a faster developer but also ensures that your code is well-structured, consistent, and follows best practices.As you grow more comfortable with using snippets, you’ll find that you can tailor them to your specific workflows, increasing your productivity and allowing you to focus more on writing business logic than dealing with repetitive code.

Happy Coding, and may your development experience be enhanced with these wonderful snippets! 😊
