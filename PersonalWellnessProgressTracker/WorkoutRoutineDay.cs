using System;

namespace PersonalWellnessProgressTracker
{
    public class WorkoutRoutineDay
    {
        public int RoutineId { get; set; }

        public int ProfileId { get; set; }

        public DayOfWeek PlannedDay { get; set; }

        public string PlannedWorkoutType { get; set; }

        public int PlannedMinutes { get; set; }

        public WorkoutRoutineDay()
        {
        }

        // NEW 06/13/2026:
        // Stores a planned workout day for one specific profile.
        public WorkoutRoutineDay(int routineId, int profileId, DayOfWeek plannedDay, string plannedWorkoutType, int plannedMinutes)
        {
            RoutineId = routineId;
            ProfileId = profileId;
            PlannedDay = plannedDay;
            PlannedWorkoutType = plannedWorkoutType;
            PlannedMinutes = plannedMinutes;
        }
    }
}