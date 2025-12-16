# RadioActivity Monitor

A .NET-based application that monitors radioactivity levels using sensors and automatically triggers alarms when measurements exceed safe thresholds.

## Overview

The RadioActivity Monitor is designed to detect unsafe radioactivity levels in real-time. It uses sensors to continuously measure radiation levels and activates an alarm whenever the readings fall outside the safe operating range (17-21 units).

## System Requirements

- **NET SDK 9.0** or later

## Project Structure

```
RadioactivityMonitor/
├── Program.cs                 # Main entry point - runs unit tests
├── RadioactivityMonitor.csproj
├── RadioactivityMonitor.sln
│
├── Contract/                  # Interface definitions
│   ├── IAlarm.cs             # Alarm interface
│   └── ISensor.cs            # Sensor interface
│
├── Service/                   # Core implementations
│   ├── Alarm.cs              # Alarm logic with threshold checking
│   └── Sensor.cs             # Radioactivity sensor implementation
│
└── UnitTests/                 # Test suite
    ├── AlarmTests.cs         # Alarm behavior tests
    ├── AssertionHelper.cs     # Custom assertion utilities
    └── MockSensor.cs         # Mock sensor for testing
```

### Safety Thresholds

| Condition | Threshold       | Alarm State |
| --------- | --------------- | ----------- |
| Below     | < 17            | **ON**      |
| Normal    | 17 ≤ value ≤ 21 | **OFF**     |
| Above     | > 21            | **ON**      |

### Building the Project

```bash
dotnet build
```

### Running the Application

Run the project with unit tests:

```bash
dotnet run
```

### How to Use

When you run the application, you'll be presented with a menu:

```
Press 1 to check the Radioactivity Monitor Alarm.
Press 2 to run the Radioactivity Monitor Alarm Tests.
```

#### Option 1: Check the Radioactivity Monitor Alarm

- Select **1** to interactively monitor radioactivity levels
- The application will:
  - Display the alarm status (**ON** or **OFF**)
- After each check, you can:
  - Press **y** to check again
  - Press **n** or any other key to exit

#### Option 2: Run the Radioactivity Monitor Alarm Tests

- Select **2** to run the comprehensive unit test suite
- Tests will display results and confirm all assertions pass

#### Any invalid user selection will exit the Radioactivity Monitor
