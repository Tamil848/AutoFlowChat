# 🧩 Auto Flowchart Application

The **Auto Flowchart Application** is a powerful tool that automatically generates flowcharts based on input data provided by the user. Just upload a file containing process steps and relationships, and the app will draw a clear and professional flowchart for you.

---

## 🚀 Features

- 📂 Upload a structured file (Excel, JSON)
- 🔄 Automatically parse and interpret process steps
- 🖼️ Visualize process flow as a flowchart
- 🧠 Intelligent node arrangement
- 🎨 Supports different shapes for decisions, processes, start/end, etc.
- 💾 Export flowchart as image or PDF

---

## 📁 Supported File Formats

| Format | Description |
|--------|-------------|
| `.xlsx`| Structured Excel sheet used to generate flowcharts |
| `.json`| Structured JSON format with steps and flow         |

---

## 📌 Sample File Format

### ✅ XLSX Format

```XLSX
📊 Sample Excel Format (Flowchart.xlsx)
| StepID | StepName    | StepType | NextStepID |
| ------ | ----------- | -------- | ---------- |
| 1      | Start       | Start    | 2          |
| 2      | Check Login | Decision | 3:Yes,4:No |
| 3      | Dashboard   | Process  | 5          |
| 4      | Show Error  | Process  | 5          |
| 5      | Logout      | End      |            |
	

### ✅ JSON Format

```JSON
[
  {"id": 1, "name": "Start", "type": "Start", "next": 2},
  {"id": 2, "name": "Check Login", "type": "Decision", "next": [3, 4]},
  {"id": 3, "name": "Dashboard", "type": "Process", "next": 5},
  {"id": 4, "name": "Show Error", "type": "Process", "next": 5},
  {"id": 5, "name": "Logout", "type": "End"}
]
