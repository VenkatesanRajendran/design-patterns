namespace Strategy
{
	class Sprint
	{
		private readonly ISprintStrategy _sprintStrategy;

		public Sprint(ISprintStrategy sprintStrategy)
		{
			_sprintStrategy = sprintStrategy;
		}

		public void ChangePhase()
		{
			_sprintStrategy.ChangeStrategy();
		}
	}
}
