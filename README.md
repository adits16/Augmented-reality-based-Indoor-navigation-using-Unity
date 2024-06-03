# Augmented-reality-based-Indoor-navigation-using-Unity
This indoor navigation system uses Augmented Reality to navigate within buildings with multiple floors. It helps the user to reach their destination with the help of augmented arrows. Unity engine is used to develop the application. A model of the indoor space is built in Unity to help map the real-world environment. The application consists of 2 modules:
1. Localization
2. Navigation
# Localization 
Localization or identification of the user's position in the indoor environment is done using QR codes. Unique QR codes are placed at strategic points on different floors in the building. They contain information about the floor the user is currently present on. This information is decoded using ZXing library and the user's position is identified.
# Navigation
Once the localization is done, the user is prompted to select the destination from the drop-down list. Route to the destination is calculated using Unity's NavMesh and A* algorithm. Directions are shown to the user in the form of augmented arrows.
# Working

<img src="https://github.com/adits16/Augmented-reality-based-Indoor-navigation-using-Unity/assets/81611120/aabdb9ef-0719-41ce-8da4-a2a2836f2c65" width="100" height="100">
<img src="https://github.com/adits16/Augmented-reality-based-Indoor-navigation-using-Unity/assets/81611120/3fbc77df-427f-4416-a14d-3d62f6278929" width="100" height="100">
<img src="https://github.com/adits16/Augmented-reality-based-Indoor-navigation-using-Unity/assets/81611120/6d5c9dad-1a25-40f2-bf95-7b31b554fe55" width="100" height="100">
<img src="https://github.com/adits16/Augmented-reality-based-Indoor-navigation-using-Unity/assets/81611120/034e1be6-3062-4dec-9328-c398dbe612c8" width="100" height="100">
<img src="https://github.com/adits16/Augmented-reality-based-Indoor-navigation-using-Unity/assets/81611120/28aa6dc5-8ebe-4145-852a-77ddf45fac13" width="100" height="100">
