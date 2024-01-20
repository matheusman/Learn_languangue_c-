class SavingsAccount : Account {

	public double Taxa { get; set; }
	public SavingsAccount () { }

	public SavingsAccount (int number, string holder, double balance, double taxa) : base(number, holder, balance) {
		Taxa = taxa;
	}

	public double SavingTaxaMethod () {
		return Balance * Taxa;
	}
}