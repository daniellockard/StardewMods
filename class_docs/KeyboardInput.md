# KeyboardInput

**Summary:** Handles player input or controls.

## Public Members
- - public static event CharEnteredHandler CharEntered;
- - public static event KeyEventHandler KeyDown;
- - public static event KeyEventHandler KeyUp;
- - public static void Initialize(GameWindow window)
- - public interface IKeyboardSubscriber

## Private Members
- - private delegate IntPtr WndProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);
- - private static bool initialized;
- - private static IntPtr prevWndProc;
- - private static WndProc hookProcDelegate;
- - private static IntPtr hIMC;
- - private const int GWL_WNDPROC = -4;
- - private const int WM_KEYDOWN = 256;
- - private const int WM_KEYUP = 257;
- - private const int WM_CHAR = 258;
- - private const int WM_IME_SETCONTEXT = 641;
- - private const int WM_INPUTLANGCHANGE = 81;
- - private const int WM_GETDLGCODE = 135;
- - private const int DLGC_WANTALLKEYS = 4;
- - private static extern IntPtr ImmGetContext(IntPtr hWnd);
- - private static extern IntPtr ImmAssociateContext(IntPtr hWnd, IntPtr hIMC);
- - private static extern IntPtr CallWindowProc(IntPtr lpPrevWndFunc, IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
- - private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
- - private static IntPtr HookProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
