using Script.CoreUObject;
using Script.Library;

namespace Script.ToolMenus
{
	[PathName("/Script/ToolMenus.ToolMenuEntryExtensions")]
	public partial class UToolMenuEntryExtensions : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ToolMenus.ToolMenuEntryExtensions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void SetToolTip(ref FToolMenuEntry Target, FText ToolTip)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Target?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ToolTip?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetToolTip, __InBuffer, __OutBuffer);

				Target = *(FToolMenuEntry*)(__OutBuffer);

			}
		}

		public static void SetStringCommand(ref FToolMenuEntry Target, EToolMenuStringCommandType Type, FName CustomType, FString String)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = Target?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Type;

				*(nint*)(__InBuffer + 9) = CustomType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 17) = String?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetStringCommand, __InBuffer, __OutBuffer);

				Target = *(FToolMenuEntry*)(__OutBuffer);

			}
		}

		public static void SetLabel(ref FToolMenuEntry Target, FText Label)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Target?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Label?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetLabel, __InBuffer, __OutBuffer);

				Target = *(FToolMenuEntry*)(__OutBuffer);

			}
		}

		public static void SetIcon(ref FToolMenuEntry Target, FName StyleSetName, FName StyleName = null, FName SmallStyleName = null)
		{
			unsafe
			{
				StyleName ??= new FName("None");

				SmallStyleName ??= new FName("None");

				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Target?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = StyleSetName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = StyleName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = SmallStyleName?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetIcon, __InBuffer, __OutBuffer);

				Target = *(FToolMenuEntry*)(__OutBuffer);

			}
		}

		public static FToolMenuOwner MakeToolMenuOwner(FName Name)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeToolMenuOwner, __InBuffer, __ReturnBuffer);

				return *(FToolMenuOwner*)__ReturnBuffer;
			}
		}

		public static FToolMenuStringCommand MakeStringCommand(EToolMenuStringCommandType Type, FName CustomType, FString String)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(byte*)(__InBuffer) = (byte)Type;

				*(nint*)(__InBuffer + 1) = CustomType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 9) = String?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeStringCommand, __InBuffer, __ReturnBuffer);

				return *(FToolMenuStringCommand*)__ReturnBuffer;
			}
		}

		public static FScriptSlateIcon MakeScriptSlateIcon(FName StyleSetName, FName StyleName, FName SmallStyleName = null)
		{
			unsafe
			{
				SmallStyleName ??= new FName("None");

				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = StyleSetName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = StyleName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SmallStyleName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeScriptSlateIcon, __InBuffer, __ReturnBuffer);

				return *(FScriptSlateIcon*)__ReturnBuffer;
			}
		}

		public static FToolMenuEntry InitMenuEntry(FName InOwner, FName InName, FText InLabel, FText InToolTip, EToolMenuStringCommandType CommandType, FName CustomCommandType, FString CommandString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[49];

				*(nint*)(__InBuffer) = InOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InLabel?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InToolTip?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)CommandType;

				*(nint*)(__InBuffer + 33) = CustomCommandType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 41) = CommandString?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __InitMenuEntry, __InBuffer, __ReturnBuffer);

				return *(FToolMenuEntry*)__ReturnBuffer;
			}
		}

		public static FText GetToolTip(FToolMenuEntry Target)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Target?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetToolTip, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static FText GetLabel(FToolMenuEntry Target)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Target?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLabel, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static void BreakToolMenuOwner(FToolMenuOwner InValue, ref FName Name)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Name?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakToolMenuOwner, __InBuffer, __OutBuffer);

				Name = *(FName*)(__OutBuffer);

			}
		}

		public static void BreakStringCommand(FToolMenuStringCommand InValue, ref EToolMenuStringCommandType Type, ref FName CustomType, ref FString String)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Type;

				*(nint*)(__InBuffer + 9) = CustomType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 17) = String?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[17];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakStringCommand, __InBuffer, __OutBuffer);

				Type = *(EToolMenuStringCommandType*)(__OutBuffer);

				CustomType = *(FName*)(__OutBuffer + 1);

				String = *(FString*)(__OutBuffer + 9);

			}
		}

		public static void BreakScriptSlateIcon(FScriptSlateIcon InValue, ref FName StyleSetName, ref FName StyleName, ref FName SmallStyleName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = StyleSetName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = StyleName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = SmallStyleName?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[24];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakScriptSlateIcon, __InBuffer, __OutBuffer);

				StyleSetName = *(FName*)(__OutBuffer);

				StyleName = *(FName*)(__OutBuffer + 8);

				SmallStyleName = *(FName*)(__OutBuffer + 16);

			}
		}

		private static uint __SetToolTip = 0;

		private static uint __SetStringCommand = 0;

		private static uint __SetLabel = 0;

		private static uint __SetIcon = 0;

		private static uint __MakeToolMenuOwner = 0;

		private static uint __MakeStringCommand = 0;

		private static uint __MakeScriptSlateIcon = 0;

		private static uint __InitMenuEntry = 0;

		private static uint __GetToolTip = 0;

		private static uint __GetLabel = 0;

		private static uint __BreakToolMenuOwner = 0;

		private static uint __BreakStringCommand = 0;

		private static uint __BreakScriptSlateIcon = 0;
	}
}