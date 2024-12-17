using Script.CoreUObject;
using Script.Library;

namespace Script.GameProjectGeneration
{
	[PathName("/Script/GameProjectGeneration.TemplateFolderRename")]
	public partial class FTemplateFolderRename : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GameProjectGeneration.TemplateFolderRename");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTemplateFolderRename() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTemplateFolderRename() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTemplateFolderRename A, FTemplateFolderRename B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTemplateFolderRename A, FTemplateFolderRename B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTemplateFolderRename;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString From
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __From, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __From, __InBuffer);
				}
			}
		}

		public FString To
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __To, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __To, __InBuffer);
				}
			}
		}

		private static uint __From = 0;

		private static uint __To = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}