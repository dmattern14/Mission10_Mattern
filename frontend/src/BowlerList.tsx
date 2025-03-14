import { useEffect, useState } from "react";
import { bowler } from "./types/Bowler";

function BowlerList () {

    const [bowlers, setbowlers] = useState<bowler[]>([]);

    useEffect(() => {
     const fetchbowler = async () => {
        const response = await fetch('https://localhost:5000/api/BowlingLeague');
        const data = await response.json();
        setbowlers(data);   
    };
    fetchbowler();
    }, []);


    

    return (
        <>
            <h1>Bowler List</h1>
            <table style={{ width: "100%", borderCollapse: "collapse", margin: "20px 0", fontSize: "16px" }}>
  <thead>
    <tr style={{ backgroundColor: "#4CAF50", color: "white", textAlign: "left" }}>
      <th style={{ padding: "10px", borderBottom: "2px solid #ddd" }}>Last Name</th>
      <th style={{ padding: "10px", borderBottom: "2px solid #ddd" }}>First Name</th>
      <th style={{ padding: "10px", borderBottom: "2px solid #ddd" }}>Middle Initial</th>
      <th style={{ padding: "10px", borderBottom: "2px solid #ddd" }}>Team Name</th>
      <th style={{ padding: "10px", borderBottom: "2px solid #ddd" }}>Address</th>
      <th style={{ padding: "10px", borderBottom: "2px solid #ddd" }}>City</th>
      <th style={{ padding: "10px", borderBottom: "2px solid #ddd" }}>State</th>
      <th style={{ padding: "10px", borderBottom: "2px solid #ddd" }}>Zip</th>
      <th style={{ padding: "10px", borderBottom: "2px solid #ddd" }}>Phone Number</th>
      
    
    </tr>
  </thead>
  <tbody>
    {bowlers
    .filter((b) => b.teamId === 1 || b.teamId === 2)
    .map((b, index) => (
      <tr key={b.bowlerId} style={{ backgroundColor: index % 2 === 0 ? "#f2f2f2" : "white" }}>
        <td style={{ padding: "8px", borderBottom: "1px solid #ddd" }}>{b.bowlerLastName}</td>
        <td style={{ padding: "8px", borderBottom: "1px solid #ddd" }}>{b.bowlerFirstName}</td>
        <td style={{ padding: "8px", borderBottom: "1px solid #ddd" }}>{b.bowlerMiddleInit}</td>
        <td style={{ padding: "8px", borderBottom: "1px solid #ddd" }}>{b.teamName}</td>
        <td style={{ padding: "8px", borderBottom: "1px solid #ddd" }}>{b.bowlerAddress}</td>
        <td style={{ padding: "8px", borderBottom: "1px solid #ddd" }}>{b.bowlerCity}</td>
        <td style={{ padding: "8px", borderBottom: "1px solid #ddd" }}>{b.bowlerState}</td>
        <td style={{ padding: "8px", borderBottom: "1px solid #ddd" }}>{b.bowlerZip}</td>
        <td style={{ padding: "8px", borderBottom: "1px solid #ddd" }}>{b.bowlerPhoneNumber}</td>
        
        
      </tr>
    ))}
  </tbody>
</table>

        </>

    );
}

export default BowlerList;
