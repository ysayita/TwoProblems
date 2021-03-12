namespace ProblemBase
{
    public interface IProblem
    {
        /// <summary>
        /// Returns the welcome text and instructions for the user.
        /// </summary>
        /// <returns>Welcome text and instructions for the user</returns>
        public string WelcomeText();
        /// <summary>
        /// Human readable name for the problem.
        /// </summary>
        /// <returns>Human readable name for the problem</returns>
        public string ProblemName();
        /// <summary>
        /// Solution of the defined problem.
        /// </summary>
        /// <param name="Input">Input parameter of the problem</param>
        /// <returns>Returns the printable result of the problem.</returns>
        public (string RunResultText, bool IsRunSuccessful) Run(string Input);
    }
}
