using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EPropertyAccessIndirectionType")]
	public enum EPropertyAccessIndirectionType : byte
	{
		Offset = 0,
		Object = 1,
		Array = 2,
		ScriptFunction = 3,
		NativeFunction = 4,
	}
}