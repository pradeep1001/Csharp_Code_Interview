using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{

	public class Program36
	{
		public enum PaymentType
		{
			WalletCash = 1,
			Stripe = 2,
			Paypal = 3,
			RazorPay = 4
		}
		public static void Main()
		{
			// Display available payment methods
			Console.WriteLine("Select a payment method:");
			Console.WriteLine("1: WalletCash");
			Console.WriteLine("2: Stripe");
			Console.WriteLine("3: Paypal");
			Console.WriteLine("4: RazorPay");

			// Read user input
			if (int.TryParse(Console.ReadLine(), out int choice) && Enum.IsDefined(typeof(PaymentType), choice))
			{
				PaymentType selectedPaymentType = (PaymentType)choice;

				// Process payment based on selected payment type
				ProcessPayment(selectedPaymentType);
			}
			else
			{
				Console.WriteLine("Invalid selection. Please enter a number between 1 and 4.");
			}

		}
		static void ProcessPayment(PaymentType paymentType)
		{
			switch (paymentType)
			{
				case PaymentType.WalletCash:
					Console.WriteLine("Processing payment through WalletCash...");
					break;
				case PaymentType.Stripe:
					Console.WriteLine("Processing payment through Stripe...");
					break;
				case PaymentType.Paypal:
					Console.WriteLine("Processing payment through PayPal...");
					break;
				case PaymentType.RazorPay:
					Console.WriteLine("Processing payment through RazorPay...");
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(paymentType), paymentType, null);
			}
		}
	}

}
