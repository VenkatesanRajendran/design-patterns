namespace Strategy
{
	class Sprint
	{
		private ISprintStrategy _sprintStrategy;

		public Sprint()
		{

		}

		public Sprint(ISprintStrategy sprintStrategy)
		{
			_sprintStrategy = sprintStrategy;
		}

		public void ChangeStrategy(ISprintStrategy sprintStrategy)
		{
			_sprintStrategy = sprintStrategy;
		}

		public void DoAction()
		{
			_sprintStrategy.PerformAction();
		}
	}
}
