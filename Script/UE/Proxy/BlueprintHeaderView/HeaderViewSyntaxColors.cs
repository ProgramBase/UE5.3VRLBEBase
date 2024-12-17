using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintHeaderView
{
	[PathName("/Script/BlueprintHeaderView.HeaderViewSyntaxColors")]
	public partial class FHeaderViewSyntaxColors : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/BlueprintHeaderView.HeaderViewSyntaxColors");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FHeaderViewSyntaxColors() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FHeaderViewSyntaxColors() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FHeaderViewSyntaxColors A, FHeaderViewSyntaxColors B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FHeaderViewSyntaxColors A, FHeaderViewSyntaxColors B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FHeaderViewSyntaxColors;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FLinearColor Comment
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Comment, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Comment, __InBuffer);
				}
			}
		}

		public FLinearColor Error
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Error, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Error, __InBuffer);
				}
			}
		}

		public FLinearColor Macro
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Macro, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Macro, __InBuffer);
				}
			}
		}

		public FLinearColor Typename
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Typename, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Typename, __InBuffer);
				}
			}
		}

		public FLinearColor Identifier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Identifier, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Identifier, __InBuffer);
				}
			}
		}

		public FLinearColor Keyword
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Keyword, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Keyword, __InBuffer);
				}
			}
		}

		private static uint __Comment = 0;

		private static uint __Error = 0;

		private static uint __Macro = 0;

		private static uint __Typename = 0;

		private static uint __Identifier = 0;

		private static uint __Keyword = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}