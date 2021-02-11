// Hello World
_=Z.z.o.C.s.H.e.l.l.o.Z.s.W.o.r.l.d.Z.e.Z.z.Z.z;

// Hello World, but it goes into a register first
_=Z.z.s.g.a.s.H.e.l.l.o.Z.s.W.o.r.l.d.Z.e.Z.z.o.C.r.g.a.Z.z;

// Hello World, but it goes into a register first, which is copied to another register before printing
_=Z.z.s.g.a.s.H.e.l.l.o.Z.s.W.o.r.l.d.Z.e.Z.z.s.g.b.r.g.a.o.C.r.g.b.Z.z;

// Hello World, but it's set up in two registers and combined before printing
_=Z.z.s.g.a.s.H.e.l.l.o.Z.z.s.g.b.s.W.o.r.l.d.Z.e.Z.z.o.C.o.a.o.a.r.g.a.s.Z.s.Z.z.r.g.b.Z.z;

// Print booleans
_=Z.z.o.C.b.t.o.C.b.f.Z.z;

// Print a boolean, negate it, then print again
_=Z.z.s.g.a.b.t.o.C.r.g.a.s.g.a.o.n.r.g.a.o.C.r.g.a.Z.z;

// Print "A" if register 'a' is true, otherwise print "B". (It's true)
_=Z.z.s.g.a.b.t.i.r.g.a.o.C.s.A.Z.z.Z.e.o.C.s.B.Z.z.Z.Z.z;

// Print "A" if register 'a' is true, otherwise print "B". (It's false)
_=Z.z.s.g.a.b.f.i.r.g.a.o.C.s.A.Z.z.Z.e.o.C.s.B.Z.z.Z.Z.z;

// Explanation of if program
_=Z.z  // Begin program
    .s.g.a .b.f  // Set global 'a': bool false
    .i.r.g.a  // If register global 'a' is true
        .o.C .s.A.Z.z  // Output to console with newline: string "A"
    .Z.e  // Else
        .o.C .s.B.Z.z  // Output to console with newline: string "B"
    .Z  // End if
.Z.z;  // End program

// Set 'a' to '5' and print. Set 'b' to 'a + 1' and print. Set 'c' to 'b + (-2)' and print.
_=Z.z.s.g.a.n.f.Z.p.o.C.r.g.a.s.g.b.o.a.r.g.a.n.b.Z.p.o.C.r.g.b.s.g.c.o.a.r.g.b.n.c.Z.n.o.C.r.g.c.Z.z;
