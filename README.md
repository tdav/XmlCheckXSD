# XmlCheckXSD

A Windows Forms application for validating XML files against multiple XSD schemas.

## Features

- **Load XML File**: Load an XML file for validation
- **Add Multiple XSD Files**: Add one or more XSD schema files
- **Validate XML**: Check if the XML file conforms to the loaded XSD schemas
- **Rich Logging**: View detailed validation results with color-coded messages

## Requirements

- .NET 10.0 or higher
- Windows operating system (WinForms application)

## Building the Application

```bash
dotnet build
```

## Running the Application

```bash
dotnet run
```

Or build and run the executable from `bin/Debug/net10.0-windows/XmlCheckXSD.exe`

## Usage

1. **Load XML File**:
   - Click `File` → `Load Xml` in the menu
   - Select the XML file you want to validate

2. **Add XSD Schema Files**:
   - Click `File` → `Add List XSD` in the menu
   - Select one or more XSD schema files
   - The files will appear in the XSD Files list
   - You can select and remove files using the "Remove" button

3. **Validate XML**:
   - Click the `Check Xml` button at the bottom
   - Validation results will appear in the log window with:
     - Green messages for successful operations
     - Red messages for errors
     - Orange messages for warnings

## Test Data

The repository includes test data in the `TestData` folder:

- `person.xsd` - Schema for person data
- `person_valid.xml` - Valid XML example
- `person_invalid.xml` - Invalid XML example (for testing error messages)
- `address.xsd` - Schema for address data
- `address_valid.xml` - Valid address XML example

## Project Structure

```
XmlCheckXSD/
├── Form1.cs              - Main form implementation
├── Form1.Designer.cs     - Form designer code
├── Program.cs            - Application entry point
├── XmlCheckXSD.csproj    - Project file
├── XmlCheckXSD.sln       - Solution file
└── TestData/             - Sample XML and XSD files
```

## License

This project is provided as-is for educational and development purposes.