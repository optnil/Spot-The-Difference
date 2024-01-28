
//populates collider information for all the levels

using UnityEngine;

public class LevelDataScript
{
    public Level[] levels;

   public LevelDataScript()
    {
        // Create and populate Level 1 data
        Level level1Data = new Level
        {
            levelName = "Level 1",
            colliders = new ColliderInfo[]
            {
                new ColliderInfo { position = new Vector2(-265f, 170f), radius = 200f },
                new ColliderInfo { position = new Vector2(20f, 0f), radius = 150f },
                new ColliderInfo { position = new Vector2(30f, -140f), radius = 120f },
                new ColliderInfo { position = new Vector2(290f, -230f), radius  = 130f},
                new ColliderInfo { position = new Vector2(-377f, -250f), radius  = 250f}
                // Add more collider data for Level 1
            }
        };

        // Create and populate Level 2 data
        Level level2Data = new Level
        {
            levelName = "Level 2",
            colliders = new ColliderInfo[]
            {
                new ColliderInfo { position = new Vector2(-300f, 170f), radius = 100f },
                new ColliderInfo { position = new Vector2(30f, 135f), radius = 250f },
                new ColliderInfo { position = new Vector2(420f, -230f), radius = 250f },
                new ColliderInfo { position = new Vector2(442f, -30f), radius  = 120f},
                new ColliderInfo { position = new Vector2(-290f, -245f), radius  = 150f}

            }
        };
        // Create and populate Level 3 data
        Level level3Data = new Level
        {
            levelName = "Level 3",
            colliders = new ColliderInfo[]
            {
                new ColliderInfo { position = new Vector2(-115f, 232f), radius = 120f },
                new ColliderInfo { position = new Vector2(256f, -100f), radius = 150f },
                new ColliderInfo { position = new Vector2(-443f, -23f), radius = 200f },
                new ColliderInfo { position = new Vector2(95f, -188f), radius  = 150f},
                new ColliderInfo { position = new Vector2(-285f, -145f), radius  = 150f}

            }
        };

        // Create and populate Level 4 data
        Level level4Data = new Level
        {
            levelName = "Level 4",
            colliders = new ColliderInfo[]
            {
                new ColliderInfo { position = new Vector2(75f, -40f), radius = 100f },
                new ColliderInfo { position = new Vector2(395f, 277f), radius = 100f },
                new ColliderInfo { position = new Vector2(-382f, 65f), radius = 250f },
                new ColliderInfo { position = new Vector2(-382f, -201f), radius  = 250f},
                new ColliderInfo { position = new Vector2(50f, 183f), radius  = 200f}

            }
        };
        // Create and populate Level 5 data
        Level level5Data = new Level
        {
            levelName = "Level 5",
            colliders = new ColliderInfo[]
            {
                new ColliderInfo { position = new Vector2(27.4f, 90f), radius = 200f},
                new ColliderInfo { position = new Vector2(-414f, -166f), radius = 200f},
                new ColliderInfo { position = new Vector2(268f, 157f), radius = 150f},
                new ColliderInfo { position = new Vector2(-455f, -45f), radius  = 120f},
                new ColliderInfo { position = new Vector2(360f, -255f), radius  = 200f}

            }
        };
        // Create and populate Level 6 data
        Level level6Data = new Level
        {
            levelName = "Level 6",
            colliders = new ColliderInfo[]
            {
                new ColliderInfo { position = new Vector2(-120f, 165f), radius = 200f },
                new ColliderInfo { position = new Vector2(263f, 63f), radius = 220f },
                new ColliderInfo { position = new Vector2(390f, 190f), radius = 230f },
                new ColliderInfo { position = new Vector2(-343f, 285f), radius  = 180f},
                new ColliderInfo { position = new Vector2(-325f, -235f), radius  = 150f}

            }
        };
        // Create and populate Level 7 data
        Level level7Data = new Level
        {
            levelName = "Level 7",
            colliders = new ColliderInfo[]
            {
                new ColliderInfo { position = new Vector2(-159f, 215f), radius = 200f },
                new ColliderInfo { position = new Vector2(310f, 220f), radius = 250f },
                new ColliderInfo { position = new Vector2(-331f, -170f), radius = 250f },
                new ColliderInfo { position = new Vector2(184f, -225f), radius  = 200f },
                new ColliderInfo { position = new Vector2(-54f, -196f), radius  = 200f }

            }
        };
        // Create and populate Level 8 data
        Level level8Data = new Level
        {
            levelName = "Level 8",
            colliders = new ColliderInfo[]
            {
                new ColliderInfo { position = new Vector2(-370f, 283f), radius = 200f },
                new ColliderInfo { position = new Vector2(-422f, 90f), radius = 200f },
                new ColliderInfo { position = new Vector2(-2.6f, 225f), radius = 150f },
                new ColliderInfo { position = new Vector2(65f, -182f), radius  = 200f },
                new ColliderInfo { position = new Vector2(435f, -38f), radius  = 180f }

            }
        };
        // Create and populate Level 9 data
        Level level9Data = new Level
        {
            levelName = "Level 9",
            colliders = new ColliderInfo[]
            {
                new ColliderInfo { position = new Vector2(-21f, -24f), radius = 200f },
                new ColliderInfo { position = new Vector2(320f, 277f), radius = 280f },
                new ColliderInfo { position = new Vector2(-110f, -172f), radius = 200f },
                new ColliderInfo { position = new Vector2(226f, -73f), radius  = 230f },
                new ColliderInfo { position = new Vector2(-318f, -268f), radius  = 250f }

            }
        };
        // Create and populate Level 10 data
        Level level10Data = new Level
        {
            levelName = "Level 10",
            colliders = new ColliderInfo[]
            {
                new ColliderInfo { position = new Vector2(-194f, 285f), radius = 240f },
                new ColliderInfo { position = new Vector2(-99f, 7f), radius = 200f },
                new ColliderInfo { position = new Vector2(-416f, -19f), radius = 150f },
                new ColliderInfo { position = new Vector2(86f, -85f), radius  = 200f},
                new ColliderInfo { position = new Vector2(-382f, -277f), radius  = 200f}

            }
        };
        // Create and populate Level 11 data
        Level level11Data = new Level
        {
            levelName = "Level 11",
            colliders = new ColliderInfo[]
            {
                new ColliderInfo { position = new Vector2(-312f, 5f), radius = 250f },
                new ColliderInfo { position = new Vector2(218f, -201f), radius = 200f },
                new ColliderInfo { position = new Vector2(20f, -19f), radius = 200f },
                new ColliderInfo { position = new Vector2(413f, -206f), radius  = 200f},
                new ColliderInfo { position = new Vector2(-158f, -230f), radius  = 200f}

            }
        };
        // Create and populate Level 12 data
        Level level12Data = new Level
        {
            levelName = "Level 12",
            colliders = new ColliderInfo[]
            {
                new ColliderInfo { position = new Vector2(-320f, 30f), radius = 180f },
                new ColliderInfo { position = new Vector2(-50f, -110f), radius = 200f },
                new ColliderInfo { position = new Vector2(-409f, 5f), radius = 180f },
                new ColliderInfo { position = new Vector2(383f, -53f), radius  = 150f},
                new ColliderInfo { position = new Vector2(52f, -209f), radius  = 200f}

            }
        };
        // Create and populate Level 13 data
        Level level13Data = new Level
        {
            levelName = "Level 13",
            colliders = new ColliderInfo[]
            {
                new ColliderInfo { position = new Vector2(-220f, 74f), radius = 220f },
                new ColliderInfo { position = new Vector2(-107f, 193f), radius = 150f },
                new ColliderInfo { position = new Vector2(-372f, -201f), radius = 200f },
                new ColliderInfo { position = new Vector2(-21f, -167f), radius  = 200f},
                new ColliderInfo { position = new Vector2(231f, -5f), radius  = 200f}

            }
        };
        // Create and populate Level 14 data
        Level level14Data = new Level
        {
            levelName = "Level 14",
            colliders = new ColliderInfo[]
            {
                new ColliderInfo { position = new Vector2(-141f, 200f), radius = 200f },
                new ColliderInfo { position = new Vector2(383f, 238f), radius = 200f },
                new ColliderInfo { position = new Vector2(247f, 105f), radius = 200f },
                new ColliderInfo { position = new Vector2(-398f, -271f), radius  = 150f},
                new ColliderInfo { position = new Vector2(123f, -197f), radius  = 200f}

            }
        };
        // Create and populate Level 15 data
        Level level15Data = new Level
        {
            levelName = "Level 15",
            colliders = new ColliderInfo[]
            {
                new ColliderInfo { position = new Vector2(89f, 198f), radius = 200f },
                new ColliderInfo { position = new Vector2(-443f, 270f), radius = 220f },
                new ColliderInfo { position = new Vector2(117f, -168f), radius = 150f },
                new ColliderInfo { position = new Vector2(-182f, -250f), radius  = 200f},
                new ColliderInfo { position = new Vector2(445f, -118f), radius  = 120f}

            }
        };

        // Assign the level data to the array
        levels = new Level[] { level1Data, level2Data, level3Data, level4Data, level5Data, level6Data, level7Data, level8Data, level9Data, level10Data, level11Data,level12Data, level13Data, level14Data, level15Data };
    }
}

