﻿#region Using References

using System;

using FluentMigrator;

#endregion

namespace CPT331.Data.Migration.Migrations
{
	[Migration(0002)]
	public class M0002 : FluentMigrator.Migration
	{
		public override void Down()
		{
			//	Nothing to see here
		}

		public override void Up()
		{
			//	States
			Insert.IntoTable("State").InSchema("Location")
				.Row(new { Name = "Australian Capital Territory", AbbreviatedName = "ACT" })
				.Row(new { Name = "New South Wales", AbbreviatedName = "NSW" })
				.Row(new { Name = "Northern Territory", AbbreviatedName = "NT" })
				.Row(new { Name = "Queensland", AbbreviatedName = "QLD" })
				.Row(new { Name = "South Australia", AbbreviatedName = "SA" })
				.Row(new { Name = "Tasmania", AbbreviatedName = "TAS" })
				.Row(new { Name = "Victoria", AbbreviatedName = "VIC" })
				.Row(new { Name = "Western Australia", AbbreviatedName = "WA" });

			//	Offences
			Insert.IntoTable("Offence").InSchema("Crime")
				.Row(new { Name = "Abduction And Kidnapping" })
				.Row(new { Name = "Abduction And Related Offences" })
				.Row(new { Name = "Abduction, Harassment And Other Offences" })
				.Row(new { Name = "Actual Break-In" })
				.Row(new { Name = "Acts Intended To Cause Injury" })
				.Row(new { Name = "Acts Intended To Cause Injury - Other" })
				.Row(new { Name = "Advertising Prostitution" })
				.Row(new { Name = "Against Justice Procedures" })
				.Row(new { Name = "Armed Robbery" })
				.Row(new { Name = "Arson" })
				.Row(new { Name = "Assault" })
				.Row(new { Name = "Assault And Related Offences" })
				.Row(new { Name = "Assault Police" })
				.Row(new { Name = "Attempted Break-In" })
				.Row(new { Name = "Attempted Murder" })
				.Row(new { Name = "Betting And Gaming Offences" })
				.Row(new { Name = "Blackmail And Extortion" })
				.Row(new { Name = "Bomb Possess And/Or Use Of" })
				.Row(new { Name = "Breach Apprehended Violence Order" })
				.Row(new { Name = "Breach Bail Conditions" })
				.Row(new { Name = "Breach Domestic Violence Protection Order" })
				.Row(new { Name = "Breaches Of Orders" })
				.Row(new { Name = "Break And Enter Dwelling" })
				.Row(new { Name = "Break And Enter Non-Dwelling" })
				.Row(new { Name = "Break-In" })
				.Row(new { Name = "Bribery" })
				.Row(new { Name = "Burglary" })
				.Row(new { Name = "Burglary/Break And Enter" })
				.Row(new { Name = "Commercial Break-Ins" })
				.Row(new { Name = "Commercial Break-Ins, Actual" })
				.Row(new { Name = "Commercial Break-Ins, Attempted" })
				.Row(new { Name = "Common Assault" })
				.Row(new { Name = "Conspiracy To Murder" })
				.Row(new { Name = "Crimes Against The Person" })
				.Row(new { Name = "Criminal Intent" })
				.Row(new { Name = "Cultivate Or Manufacture Drugs" })
				.Row(new { Name = "Cultivating Cannabis" })
				.Row(new { Name = "Dangerous And Negligent Acts Endangering People" })
				.Row(new { Name = "Dangerous Operation Of A Vehicle" })
				.Row(new { Name = "Dealing, Trafficking In Amphetamines" })
				.Row(new { Name = "Dealing, Trafficking In Cannabis" })
				.Row(new { Name = "Dealing, Trafficking In Cocaine" })
				.Row(new { Name = "Dealing, Trafficking In Ecstasy" })
				.Row(new { Name = "Dealing, Trafficking In Narcotics" })
				.Row(new { Name = "Dealing, Trafficking In Other Drugs" })
				.Row(new { Name = "Deception" })
				.Row(new { Name = "Deprivation Of Liberty/False Imprisonment" })
				.Row(new { Name = "Disobey Move-On Direction" })
				.Row(new { Name = "Disorderly And Offensive Conduct" })
				.Row(new { Name = "Disorderly Conduct" })
				.Row(new { Name = "Disqualified Driving" })
				.Row(new { Name = "Domestic Violence" })
				.Row(new { Name = "Domestic Violence Related Assault" })
				.Row(new { Name = "Drink Driving" })
				.Row(new { Name = "Driving Causing Death" })
				.Row(new { Name = "Drug Dealing And Trafficking" })
				.Row(new { Name = "Drug Offences" })
				.Row(new { Name = "Drug Use And Possession" })
				.Row(new { Name = "Escape Custody" })
				.Row(new { Name = "Extortion" })
				.Row(new { Name = "Fail To Appear" })
				.Row(new { Name = "Fare Evasion" })
				.Row(new { Name = "Found In Places Used For Purpose Of Prostitution Offences" })
				.Row(new { Name = "Fraud" })
				.Row(new { Name = "Fraud By Cheque" })
				.Row(new { Name = "Fraud By Computer" })
				.Row(new { Name = "Fraud By Credit Card" })
				.Row(new { Name = "Gaming Racing & Betting Offences" })
				.Row(new { Name = "Good Order Offences" })
				.Row(new { Name = "Grievous Assault" })
				.Row(new { Name = "Handling Stolen Goods" })
				.Row(new { Name = "Harassment And Private Nuisance" })
				.Row(new { Name = "Harassment, Threatening Behaviour And Private Nuisance" })
				.Row(new { Name = "Have Interest In Premises Used For Prostitution Offences" })
				.Row(new { Name = "Homicide" })
				.Row(new { Name = "Homicide (Murder)" })
				.Row(new { Name = "Homicide And Related Offences" })
				.Row(new { Name = "House Break-Ins" })
				.Row(new { Name = "House Break-Ins, Actual" })
				.Row(new { Name = "House Break-Ins, Attempted" })
				.Row(new { Name = "Identity Fraud" })
				.Row(new { Name = "Illegal Use Of A Motor Vehicle" })
				.Row(new { Name = "Illegal Use Of Motor Vehicle" })
				.Row(new { Name = "Importing Drugs" })
				.Row(new { Name = "Indecent Assault, Act Of Indecency And Other Sexual Offences" })
				.Row(new { Name = "Interfere With Mechanism Of Motor Vehicle" })
				.Row(new { Name = "Justice Procedures" })
				.Row(new { Name = "Justice Procedures Offences" })
				.Row(new { Name = "Kidnapping & Abduction Etc." })
				.Row(new { Name = "Knowingly Participate In Provision Prostitution Offences" })
				.Row(new { Name = "Life Endangering Acts" })
				.Row(new { Name = "Liquor (Excl. Drunkenness)" })
				.Row(new { Name = "Liquor Offences" })
				.Row(new { Name = "Malicious Damage To Property" })
				.Row(new { Name = "Manslaughter" })
				.Row(new { Name = "Manslaughter (A)" })
				.Row(new { Name = "Manslaughter (Excl. By Driving)" })
				.Row(new { Name = "Manslaughter Unlawful Striking Causing Death" })
				.Row(new { Name = "Manufacture Drug" })
				.Row(new { Name = "Miscellaneous Offences" })
				.Row(new { Name = "Motor Vehicle Theft" })
				.Row(new { Name = "Motor Vehicle Theft And Related Offences" })
				.Row(new { Name = "Murder" })
				.Row(new { Name = "Murder (A)" })
				.Row(new { Name = "Murder Accessory, Conspiracy" })
				.Row(new { Name = "Non-Assaultive Sexual Offences" })
				.Row(new { Name = "Non-Domestic Violence Related Assault" })
				.Row(new { Name = "Offences Against A Person" })
				.Row(new { Name = "Offences Against Property" })
				.Row(new { Name = "Offences Against The Person" })
				.Row(new { Name = "Offensive Conduct" })
				.Row(new { Name = "Offensive Language" })
				.Row(new { Name = "Other Dangerous Or Negligent Acts Endangering Persons" })
				.Row(new { Name = "Other Drug Offences" })
				.Row(new { Name = "Other Fraud" })
				.Row(new { Name = "Other Government Regulatory Offences" })
				.Row(new { Name = "Other Handling Stolen Goods" })
				.Row(new { Name = "Other Homicide" })
				.Row(new { Name = "Other Offences" })
				.Row(new { Name = "Other Offences Against Justice Procedures" })
				.Row(new { Name = "Other Offences Against The Person" })
				.Row(new { Name = "Other Property Damage" })
				.Row(new { Name = "Other Prostitution Offences" })
				.Row(new { Name = "Other Sexual Offences" })
				.Row(new { Name = "Other Stealing" })
				.Row(new { Name = "Other Theft" })
				.Row(new { Name = "Other Theft (Excl. Unlawful Entry)" })
				.Row(new { Name = "Permit Minor To Be At A Place Used For Prostitution Offences" })
				.Row(new { Name = "Pornography Offences" })
				.Row(new { Name = "Possess And/Or Use Other Weapons; Restricted Items" })
				.Row(new { Name = "Possess Drugs" })
				.Row(new { Name = "Possess Etc. Tainted Property" })
				.Row(new { Name = "Possess Property Suspected Stolen" })
				.Row(new { Name = "Possession And/Or Use Of Amphetamines" })
				.Row(new { Name = "Possession And/Or Use Of Cannabis" })
				.Row(new { Name = "Possession And/Or Use Of Cocaine" })
				.Row(new { Name = "Possession And/Or Use Of Ecstasy" })
				.Row(new { Name = "Possession And/Or Use Of Narcotics" })
				.Row(new { Name = "Possession And/Or Use Of Other Drugs" })
				.Row(new { Name = "Procuring Prostitution" })
				.Row(new { Name = "Produce Drugs" })
				.Row(new { Name = "Prohibited And Regulated Weapons Offences" })
				.Row(new { Name = "Property And Deception Offences" })
				.Row(new { Name = "Property Damage" })
				.Row(new { Name = "Property Damage Offences" })
				.Row(new { Name = "Prostitution Offences" })
				.Row(new { Name = "Public Nuisance" })
				.Row(new { Name = "Public Nuisance Offences" })
				.Row(new { Name = "Public Order And Security Offences" })
				.Row(new { Name = "Public Security Offences" })
				.Row(new { Name = "Public Soliciting" })
				.Row(new { Name = "Rape And Attempted Rape" })
				.Row(new { Name = "Receiving Or Handling Stolen Goods" })
				.Row(new { Name = "Receiving Stolen Property" })
				.Row(new { Name = "Regulatory Driving Offences" })
				.Row(new { Name = "Resist Incite Hinder Obstruct Police" })
				.Row(new { Name = "Resist Or Hinder Officer" })
				.Row(new { Name = "Road Collision With Injury" })
				.Row(new { Name = "Road Fatality" })
				.Row(new { Name = "Robbery" })
				.Row(new { Name = "Robbery, Extortion And Related Offences" })
				.Row(new { Name = "Robbery With A Firearm" })
				.Row(new { Name = "Robbery With A Weapon Not A Firearm" })
				.Row(new { Name = "Robbery Without A Weapon" })
				.Row(new { Name = "Sell Supply Drugs" })
				.Row(new { Name = "Serious Assault" })
				.Row(new { Name = "Serious Assault (Other)" })
				.Row(new { Name = "Sexual Assault" })
				.Row(new { Name = "Sexual Assault And Related Offences" })
				.Row(new { Name = "Sexual Offences" })
				.Row(new { Name = "Shop Stealing" })
				.Row(new { Name = "Stalking" })
				.Row(new { Name = "Stalking, Harassment And Threatening Behaviour" })
				.Row(new { Name = "Steal From Dwelling" })
				.Row(new { Name = "Steal From Motor Vehicle" })
				.Row(new { Name = "Steal From Person" })
				.Row(new { Name = "Steal From Retail Store" })
				.Row(new { Name = "Stealing From Dwellings" })
				.Row(new { Name = "Stock Related Offences" })
				.Row(new { Name = "Stock Theft" })
				.Row(new { Name = "Theft" })
				.Row(new { Name = "Theft (Excluding Motor Vehicles)" })
				.Row(new { Name = "Theft And Related Offences (Other Than Mv)" })
				.Row(new { Name = "Theft Of Motor Vehicle Parts Or Contents" })
				.Row(new { Name = "Threatening Behaviour" })
				.Row(new { Name = "Tins" })
				.Row(new { Name = "Traffic And Related Offences" })
				.Row(new { Name = "Trafficking Drugs" })
				.Row(new { Name = "Transport Regulation Offences" })
				.Row(new { Name = "Transport Regulatory Offences" })
				.Row(new { Name = "Trespass" })
				.Row(new { Name = "Trespassing And Vagrancy" })
				.Row(new { Name = "Unarmed Robbery" })
				.Row(new { Name = "Unlawful Entry" })
				.Row(new { Name = "Unlawful Entry With Intent - Dwelling" })
				.Row(new { Name = "Unlawful Entry With Intent - Other" })
				.Row(new { Name = "Unlawful Entry With Intent - Shop" })
				.Row(new { Name = "Unlawful Entry With Violence - Dwelling" })
				.Row(new { Name = "Unlawful Entry Without Violence - Dwelling" })
				.Row(new { Name = "Unlawful Possess Concealable Firearm" })
				.Row(new { Name = "Unlawful Possess Firearm - Other" })
				.Row(new { Name = "Unlawful Use Of Motor Vehicle" })
				.Row(new { Name = "Vehicles (Steal From/Enter With Intent)" })
				.Row(new { Name = "Weapons Act Offences" })
				.Row(new { Name = "Weapons Act Offences - Other" })
				.Row(new { Name = "Weapons And Explosives Offences" });

			Execute.EmbeddedScript("M0002.sql");
		}
	}
}