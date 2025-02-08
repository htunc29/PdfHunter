# PDFHunter - Parallel PDF File Search Tool

**PDFHunter** is a tool that allows users to quickly search for keywords in PDF files within a selected folder. Thanks to parallel search technology, it speeds up the process by searching multiple files at the same time.

## Features

- **Parallel Search**: Speeds up the search process by scanning multiple PDF files simultaneously.
- **Fast and Easy to Use**: User-friendly interface for easy file selection and keyword search.
- **Search Across All PDF Files**: Search all PDF files in the selected folder.
- **Progress Tracking**: Track the progress with a progress bar and taskbar indicator during the search process.

## Requirements

- **Windows Forms** (Windows Forms application in Visual Studio)
- **iText** (For reading PDF files and extracting text)
- **.NET Framework 4.7.2** or later
- **Guna UI** 

## Installation

1. Clone this repository or download the source code.
2. Open the project in Visual Studio.
3. Install the necessary NuGet packages:
   - **iText**:
     ```bash
     Install-Package itext
     ```
4. Run the project and start scanning your PDF files!

## Usage

1. **Select Folder**: Choose the folder containing the PDF files.
2. **Enter Keyword**: Type the keyword you want to search for.
3. **Start Search**: Begin the search process and view results instantly.

### Example Steps:

- When the application opens, click the button to select the folder containing PDF files.
- Enter the keyword you want to search for and click the search button.
- During the search, the progress will be shown.
- Results will be displayed with the PDF files that contain the searched keyword.

## License

This project is licensed under the MIT License - see the [LICENSE.txt](LICENSE.txt) file for details.

## Credits

- **iText**: [iText GitHub Repository](https://github.com/itext/itext7)
- **PDFHunter**: [PDFHunter GitHub Repository](https://github.com/htunc29/PDFHunter)

Start saving time by quickly searching through your PDF files! 🚀
