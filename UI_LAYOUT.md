# XmlCheckXSD Application - User Interface Layout

## Main Window Structure

```
┌─────────────────────────────────────────────────────────────────────┐
│ XML Check XSD - XML Validator                                  [_][□][X]│
├─────────────────────────────────────────────────────────────────────┤
│ File                                                                 │
│  ├─ Load Xml                                                         │
│  └─ Add List XSD                                                     │
├─────────────────────────────────────────────────────────────────────┤
│ ┌─ XSD Files ──────────────────────────────────────────────────┐    │
│ │                                                              │[Remove]│
│ │ • person.xsd                                                │    │
│ │ • address.xsd                                               │    │
│ │                                                              │    │
│ │                                                              │    │
│ └──────────────────────────────────────────────────────────────┘    │
├─────────────────────────────────────────────────────────────────────┤
│ ┌─ Validation Log ─────────────────────────────────────────────┐    │
│ │                                                              │    │
│ │ Loaded XML file: person_valid.xml                           │    │
│ │ Added XSD file: person.xsd                                  │    │
│ │ Starting XML validation...                                   │    │
│ │ XML File: C:\...\person_valid.xml                           │    │
│ │ XSD Files: 1                                                 │    │
│ │ ───────────────────────────────────────────────────────     │    │
│ │ Loaded schema: person.xsd                                   │    │
│ │ ───────────────────────────────────────────────────────     │    │
│ │ ✓ Validation successful! No errors found.                   │    │
│ │                                                              │    │
│ └──────────────────────────────────────────────────────────────┘    │
├─────────────────────────────────────────────────────────────────────┤
│ No XML file loaded                                   [Check Xml]    │
└─────────────────────────────────────────────────────────────────────┘
```

## UI Components

### 1. Menu Bar (Top)
- **File Menu**
  - **Load Xml**: Opens file dialog to select an XML file for validation
  - **Add List XSD**: Opens file dialog to add one or more XSD schema files

### 2. XSD Files Section (Upper Panel)
- **ListBox**: Displays names of loaded XSD schema files
- **Remove Button**: Removes selected XSD file from the list

### 3. Validation Log Section (Lower Panel)
- **RichTextBox**: Displays validation logs with color-coded messages:
  - 🔵 Blue: Information messages (file loaded, validation started)
  - 🟢 Green: Success messages (schema loaded, validation passed)
  - 🟠 Orange: Warning messages (file removed, schema warnings)
  - 🔴 Red: Error messages (validation errors, exceptions)

### 4. Bottom Panel
- **Label**: Shows currently loaded XML file name or "No XML file loaded"
- **Check Xml Button**: Starts the validation process

## Workflow

1. **Load XML File**:
   - Click `File` → `Load Xml`
   - Select XML file
   - File path displayed in bottom label
   - Log shows: "Loaded XML file: [filename]"

2. **Add XSD Schemas**:
   - Click `File` → `Add List XSD`
   - Select one or more XSD files (multi-select supported)
   - Files appear in XSD Files list
   - Log shows: "Added XSD file: [filename]" for each file

3. **Validate**:
   - Click `Check Xml` button
   - Validation results appear in log with:
     - List of schemas loaded
     - Validation errors (if any) with line/position numbers
     - Success or failure message
   - Message box shows summary

## Color Coding in Validation Log

- **Blue**: Process information (starting validation, file paths)
- **Green**: Successful operations (schemas loaded, validation passed)
- **Orange**: Warnings and removals
- **Red**: Errors and exceptions
- **Gray**: Separators and formatting
- **Black**: General information

## Example Validation Output (Success)

```
Loaded XML file: C:\TestData\person_valid.xml
Added XSD file: C:\TestData\person.xsd
Starting XML validation...
XML File: C:\TestData\person_valid.xml
XSD Files: 1
──────────────────────────────────────────────────────────────────────────
Loaded schema: person.xsd
──────────────────────────────────────────────────────────────────────────
✓ Validation successful! No errors found.
```

## Example Validation Output (Failure)

```
Starting XML validation...
XML File: C:\TestData\person_invalid.xml
XSD Files: 1
──────────────────────────────────────────────────────────────────────────
Loaded schema: person.xsd
[ERROR] Line 2, Position 14:
  The 'id' attribute is invalid - The value 'abc' is invalid according to its datatype 'http://www.w3.org/2001/XMLSchema:positiveInteger'
[ERROR] Line 4, Position 8:
  The 'age' element is invalid - The value '-5' is invalid according to its datatype 'http://www.w3.org/2001/XMLSchema:positiveInteger'
[ERROR] Line 6, Position 10:
  The element 'person' has invalid child element 'extra'
──────────────────────────────────────────────────────────────────────────
✗ Validation failed with 3 error(s).
```
