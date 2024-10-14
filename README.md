# 📘 Facebook Feature Enhancements with Design Patterns

### 📝 Overview
This project involves improving the Facebook interface with two key features: **Personality Insights** and **Personal Goal Tracker**, utilizing various design patterns to ensure maintainability and scalability. The enhancements provide users with personalized insights based on their Facebook activities and a tool to track personal goals while receiving relevant recommendations.

---

## 💡 Features

### 1. Personality Insights:
   - **Top Topics**: Analyze and display the most frequently discussed topics based on user posts.
   - **Sentiment Score**: Measure and visualize the sentiment of user posts over time, giving a percentage-based score.
   - **Main Interests**: Identify key interests based on user activities and interactions.
   - **Photo Preferences**: Show user preferences regarding photo uploads (e.g., most common type of photo).
   - **Activity Pattern**: Track user activity and post frequency, including the most active hour of posting.

![Personality Insights](Screenshots/Screenshot_2024-10-14_115600.png)
*An example of Personality Insights showing top topics, sentiment score, and more.*

---

### 2. Personal Goal Tracker:
   - **Goal Creation and Tracking**: Users can create, update, and track personal goals (e.g., health, education) with a progress bar.
   - **Relevant Pages**: Automatically suggest relevant Facebook pages based on the user’s goals.
   - **Goal Sharing**: Allow users to share their progress with friends on Facebook.
   - **Design Pattern**: Implements the **Observer** pattern to notify users about related content and **Strategy** pattern for different goal categories.

![Personal Goal Tracker](Screenshots/Screenshot_2024-10-14_115705.png)
*An example of the Personal Goal Tracker where users can manage their goals and receive relevant suggestions.*

---

## 🔧 Design Patterns Used

- **Observer Pattern**: This pattern is used to track changes in user activities and update the Personality Insights in real-time. When the user performs an action (like posting or updating), the insights are updated.
- **Strategy Pattern**: The Personal Goal Tracker uses different strategies for various goal categories (e.g., health, career, education), allowing flexibility in how goals are handled and displayed.
- **Singleton Pattern**: Ensures that certain components, such as the Insights and Goal Tracker, have only one instance throughout the application for consistency.
- **Facade Pattern**: Provides a simplified interface to complex functionalities, such as analyzing user sentiment or suggesting relevant Facebook pages.

---

## 🔧 Installation

### Requirements:
- **Visual Studio 2022** or higher.
- **.NET Framework 4.8**.

### Steps:
1. Clone the repository:
   ```bash
   git clone https://github.com/itzhakGal/FacebookFeatureEnhancements.git
2. Open the project in **Visual Studio**.
3. Build and run the project.

---

## 📚 Usage

### Personality Insights:
1. View insights based on your posts.
2. Track your sentiment score and identify your main interests.
3. Discover patterns in your activity, such as your most active hour.

### Personal Goal Tracker:
1. Create a goal and track your progress.
2. Automatically receive relevant page recommendations based on your goal.
3. Share your progress with friends.

---
