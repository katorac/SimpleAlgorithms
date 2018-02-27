using System;

namespace SimpleAlgorithms
{
	public class Composition
	{
		public void Compose()
		{
			IRunner nick = new Athlete() { FullName = "Nick Greyling" };
			IJumper penny = new Athlete() { FullName = "Penny Cusso" };

			var runnerComposition = new RunnerComposition(nick, penny);
			runnerComposition.Run(); // Nick Greyling is running
			runnerComposition.Jump(); // Penny Cusso is jumping
		}
	}

	public class RunnerComposition
	{
		private IRunner _runner;
		private IJumper _jumper;

		public RunnerComposition(IRunner runner, IJumper jumper = null)
		{
			this._runner = runner;
			this._jumper = jumper;
		}

		public void Run()
		{
			this._runner.Run();
		}

		public void Jump()
		{
			this._jumper?.Jump();
		}
	}

	public interface IRunner
	{
		void Run();
	}

	public interface IJumper
	{
		void Jump();
	}

	public class Athlete : IRunner, IJumper
	{
		public String FullName { get; set; }

		public void Jump()
		{
			Console.WriteLine($"{this.FullName} is jumping");
		}

		public void Run()
		{
			Console.WriteLine($"{this.FullName} is running");
		}
	}

}
