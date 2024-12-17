using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDataChannelHandler")]
	public partial class UNiagaraDataChannelHandler : UObject, IStaticClass
	{
		public TWeakObjectPtr<UNiagaraDataChannel> DataChannel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DataChannel, __ReturnBuffer);

					return *(TWeakObjectPtr<UNiagaraDataChannel>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DataChannel, __InBuffer);
				}
			}
		}

		public UNiagaraDataChannelWriter Writer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Writer, __ReturnBuffer);

					return *(UNiagaraDataChannelWriter*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Writer, __InBuffer);
				}
			}
		}

		public UNiagaraDataChannelReader Reader
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Reader, __ReturnBuffer);

					return *(UNiagaraDataChannelReader*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Reader, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraDataChannelHandler");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual UNiagaraDataChannelWriter GetDataChannelWriter()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDataChannelWriter, __ReturnBuffer);

				return *(UNiagaraDataChannelWriter*)__ReturnBuffer;
			}
		}

		public virtual UNiagaraDataChannelReader GetDataChannelReader()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDataChannelReader, __ReturnBuffer);

				return *(UNiagaraDataChannelReader*)__ReturnBuffer;
			}
		}

		private static uint __DataChannel = 0;

		private static uint __Writer = 0;

		private static uint __Reader = 0;

		private static uint __GetDataChannelWriter = 0;

		private static uint __GetDataChannelReader = 0;
	}
}