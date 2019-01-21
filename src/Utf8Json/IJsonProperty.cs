namespace Utf8Json
{
	public interface IJsonProperty
	{
		string Name { get; set; }

		int Order { get; }

		bool Ignore { get; set; }
	}
}
