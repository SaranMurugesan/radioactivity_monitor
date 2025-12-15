# RadioActivity Monitor

A .NET-based application that monitors radioactivity levels using sensors and automatically triggers alarms when measurements exceed safe thresholds.

## Overview

The RadioActivity Monitor is designed to detect unsafe radioactivity levels in real-time. It uses sensors to continuously measure radiation levels and activates an alarm whenever the readings fall outside the safe operating range (17-21 units).

## System Requirements

- __NET SDK 9.0__ or later

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

| Condition | Threshold | Alarm State |
|-----------|-----------|------------|
| Below | < 17 | **ON** |
| Normal | 17 ≤ value ≤ 21 | **OFF** |
| Above | > 21 | **ON** |

### Running the Application

Run the project with unit tests:
```bash
dotnet run
```

This will execute the test suite and display results:
```
===== Start Testing Radioactivity Monitor Alarm =====
Total Tests: 5, Passed: 5, Failed: 0
===== End Testing Radioactivity Monitor Alarm =====
```

### Building the Project

```bash
dotnet build
```