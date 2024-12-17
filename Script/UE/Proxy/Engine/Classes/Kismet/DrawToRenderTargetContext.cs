using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DrawToRenderTargetContext")]
	public partial class FDrawToRenderTargetContext : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.DrawToRenderTargetContext");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDrawToRenderTargetContext() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDrawToRenderTargetContext() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDrawToRenderTargetContext A, FDrawToRenderTargetContext B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDrawToRenderTargetContext A, FDrawToRenderTargetContext B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDrawToRenderTargetContext;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UTextureRenderTarget2D RenderTarget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RenderTarget, __ReturnBuffer);

					return *(UTextureRenderTarget2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RenderTarget, __InBuffer);
				}
			}
		}

		private static uint __RenderTarget = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}