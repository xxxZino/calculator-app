class calculator
{
	static void main (string [] args)
	{
		int a = 10;
		int b = 6;
		
		console.writeline("Hasil penambahan: {0} + {1} = {2}", a, b, Penambahan (a, b));
		console.writeline("Hasil pengurangan: {0} - {1} = {2}", a, b, Pengurangan (a, b));
		
		console.writeline("\nTekan sembarang key untuk keluar");
		console.redkey();
	}
		
		static int Penambahan (int a, int b)
		{
			return a + b;
		}
}