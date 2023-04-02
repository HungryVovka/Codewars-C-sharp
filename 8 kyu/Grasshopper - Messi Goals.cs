// -----------------------------------------------------------
// Messi's Goal Total
// Use variables to find the sum of the goals Messi scored in 3 competitions
// 
// Information
// Messi goal scoring statistics:
// 
// Competition				Goals
// La Liga					43
// Champions League		10
// Copa del Rey			5
// 
// Task
// Create these three variables and store the appropriate values using the table above:
// laLigaGoals
// championsLeagueGoals
// copaDelReyGoals
// 
// Create a fourth variable named totalGoals that stores the sum of all of Messi's goals for this year.
// -----------------------------------------------------------

using System;

public static class Kata 
{
	public static int la_liga_goals = 43;
	public static int champions_league_goals = 10;
	public static int copa_del_rey_goals = 5;
	public static int total_goals = 
		la_liga_goals + champions_league_goals + copa_del_rey_goals;
}