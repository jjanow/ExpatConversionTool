# Expat Conversion Tool

A desktop application built with C# and WPF (.NET Core) to assist US expatriates in the UK. This tool provides quick conversions between temperatures, metric and imperial units, and displays local times in the UK and US Eastern Time (EST), automatically accounting for Daylight Saving Time.

## Features

- **Temperature Conversion**: Convert temperatures between Celsius and Fahrenheit.
- **Metric to Imperial Conversion**: Convert units like kilometers to miles and kilograms to pounds.
- **Time Display**: View current local time in the UK and US EST, with automatic Daylight Saving Time adjustments.

## Prerequisites

- **Operating System**: Windows 10 or later.
- **.NET SDK**: [Download .NET 6.0 SDK or later](https://dotnet.microsoft.com/download).
- **Visual Studio**: [Download Visual Studio 2022](https://visualstudio.microsoft.com/vs/) (Community Edition is sufficient).
  - Ensure the **.NET Desktop Development** workload is installed during setup.

## Installation

1. **Clone the Repository**

   ```bash
   git clone https://github.com/yourusername/ExpatConversionTool.git
   ```

2. **Open the Solution**

   - Navigate to the project directory.
   - Open `ExpatConversionTool.sln` with Visual Studio.

3. **Restore NuGet Packages**

   - Visual Studio should automatically restore any required NuGet packages upon opening the solution.
   - If not, right-click on the solution in the **Solution Explorer** and select **Restore NuGet Packages**.

## Usage

1. **Build the Solution**

   - Press **Ctrl + Shift + B** or navigate to **Build > Build Solution** in Visual Studio.

2. **Run the Application**

   - Press **F5** or click the **Start** button to run the application.

3. **Using the Application**

   - **Temperature Conversion**:
     - Enter a temperature value in the input box.
     - Select the conversion type (Celsius to Fahrenheit or Fahrenheit to Celsius).
     - Click **Convert** to display the result.
   - **Metric to Imperial Conversion**:
     - Enter a value in the input box.
     - Select the conversion type (e.g., Kilometers to Miles, Kilograms to Pounds).
     - Click **Convert** to display the result.
   - **Time Display**:
     - View the current local time in the UK and US Eastern Time (EST).
     - The times update every second and adjust automatically for Daylight Saving Time.

## Screenshots

![Temperature Conversion](screenshots/temperature_conversion.png)
*Temperature Conversion Section*

![Metric Conversion](screenshots/metric_conversion.png)
*Metric to Imperial Conversion Section*

![Time Display](screenshots/time_display.png)
*Time Display Section*

## Extending the Application

Feel free to add more conversion types or features to the application:

- **Additional Conversions**:
  - Add units like liters to gallons, meters to feet, etc.
  - Update the `ComboBox` items and the corresponding conversion logic in the code-behind.

- **Improved User Interface**:
  - Enhance the UI with custom styles, themes, or animations.
  - Implement data binding for a more robust architecture.

- **Error Handling and Validation**:
  - Add input validation to handle incorrect or invalid inputs.
  - Provide user feedback with error messages or warnings.

## Contributing

Contributions are welcome! Please follow these steps to contribute:

1. **Fork the Repository**

   - Click the **Fork** button on the GitHub repository page.

2. **Create a Feature Branch**

   ```bash
   git checkout -b feature/your-feature-name
   ```

3. **Commit Your Changes**

   ```bash
   git commit -am 'Add a new feature'
   ```

4. **Push to the Branch**

   ```bash
   git push origin feature/your-feature-name
   ```

5. **Open a Pull Request**

   - Go to your forked repository on GitHub.
   - Click on **Pull Requests** and open a new pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- Inspired by the need to assist US expatriates adjusting to life in the UK.
- Thanks to all contributors who have helped improve this project.

## Contact

For questions or suggestions, please open an issue on the [GitHub repository](https://github.com/yourusername/ExpatConversionTool/issues).

---

*This README was generated to provide a comprehensive guide to the Expat Conversion Tool project. It includes all necessary information to get started and contribute to the project.*
