using Script.CoreUObject;
using Script.Library;

namespace Script.GameProjectGeneration
{
	[PathName("/Script/GameProjectGeneration.LocalizedTemplateString")]
	public partial class FLocalizedTemplateString : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GameProjectGeneration.LocalizedTemplateString");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLocalizedTemplateString() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLocalizedTemplateString() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLocalizedTemplateString A, FLocalizedTemplateString B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLocalizedTemplateString A, FLocalizedTemplateString B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLocalizedTemplateString;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Language
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Language, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Language, __InBuffer);
				}
			}
		}

		public FString Text
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Text, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Text, __InBuffer);
				}
			}
		}

		private static uint __Language = 0;

		private static uint __Text = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}