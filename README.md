[![.NET Build](https://github.com/MSCHUNLI23/CyberChatBotGUI/actions/workflows/dotnet.yml/badge.svg)](https://github.com/MSCHUNLI23/CyberChatBotGUI/actions/workflows/dotnet.yml)
# Cybersecurity Awareness Chatbot

A comprehensive WPF-based cybersecurity education application that helps users learn about online safety through interactive conversations, voice greetings, ASCII art visualization, and personalized memory features.

##Table of Contents
- [Overview](#overview)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Project Structure](#project-structure)
- [Installation](#installation)
- [How to Use](#how-to-use)
- [File Descriptions](#file-descriptions)
- [Data Storage](#data-storage)
- [Keyboard Shortcuts](#keyboard-shortcuts)
- [Troubleshooting](#troubleshooting)
- [Future Enhancements](#future-enhancements)
- [Author](#author)
- [License](#license)

## Overview

The Cybersecurity Awareness Chatbot is an educational desktop application designed to:
- Educate users about cybersecurity threats and prevention
- Provide personalized learning experiences through memory features
- Offer empathetic responses based on sentiment detection
- Convert images to ASCII art for visual engagement
- Remember user interests and preferences across sessions

## Features

### 1. Voice Greeting
- Plays a recorded voice greeting when the application launches
- Uses `System.Media.SoundPlayer` for audio playback
- Gracefully handles missing audio files

### 2. ASCII Art Converter
- Converts any image (PNG, JPG, BMP) to ASCII art
- Maintains aspect ratio during conversion
- Preserves color information in the ASCII output
- Displays in a scrollable viewer within the GUI

### 3. User Management
- Stores user names in `user_names.txt`
- Recognizes returning users and provides personalized welcome messages
- Tracks user interests in `interested_topic.txt`

### 4. Intelligent Response System
- Keyword-based response matching for cybersecurity topics:
  - Password safety
  - Phishing and scams
  - Privacy protection
  - Safe browsing
  - Two-factor authentication (2FA)
  - VPNs and firewalls
  - Software updates

### 5. Sentiment Detection
- Detects user emotions from text input:
  -  Worried
  -  Curious
  -  Frustrated
  -  Happy
  -  Sad
  - Angry
- Provides empathetic, context-appropriate responses

### 6. Memory & Recall
- Remembers user names across sessions
- Tracks user interests (e.g., "I'm interested in privacy")
- Recalls interests after 3 messages to continue relevant conversations
- Stores all data in text files for persistence

### 7. Follow-up Question Handling
- Responds to "tell me more", "another tip", "explain more"
- Continues current topic without requiring keyword repetition
- Provides additional random tips on the same subject

### 8. Random Response System
- Multiple response variations for each topic using arrays
- Random selection keeps conversations fresh and engaging
- Prevents repetitive answers

### 9. Input Validation
- Handles empty inputs gracefully
- Removes special characters that could break keyword matching
- Ignores common stop words (a, an, the, and, etc.)
- Provides helpful error messages

### 10. Modern GUI Design
- Dark theme with cybersecurity-inspired colors
- Color-coded messages (bot vs. user)
- Scrollable chat area with auto-scroll
- Three-screen navigation flow:
  - Home screen with logo and welcome
  - Username input screen
  - Main chat interface

##Technologies Used

| Technology | Purpose |
|------------|---------|
| **C# .NET Framework 4.7.2** | Core programming language |
| **WPF (Windows Presentation Foundation)** | GUI framework |
| **XAML** | UI design and layout |
| **System.Media** | Voice greeting playback |
| **System.Drawing** | Image processing for ASCII art |
| **System.IO** | File storage for user data |
| **System.Collections** | ArrayList for response storage |
| **System.Text.RegularExpressions** | Text cleaning and validation |

## Project Structure
