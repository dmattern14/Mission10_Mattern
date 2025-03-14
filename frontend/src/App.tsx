import BowlerList from './BowlerList'
import './App.css'

const PageHeader = () => {
  return (
    <div
      style={{
        backgroundColor: "#4CAF50",
        color: "white",
        padding: "20px",
        textAlign: "center",
        borderRadius: "8px",
        boxShadow: "0px 4px 10px rgba(0, 0, 0, 0.1)",
        marginBottom: "20px",
      }}
    >
      <h1 style={{ margin: 0, fontSize: "28px" }}>Bowler Directory</h1>
      <p style={{ margin: "5px 0", fontSize: "16px" }}>
        View detailed information about bowlers on the Marlins and Sharks team!
      </p>
    </div>
  );
};

function App() {

  return (
    <>
    <PageHeader />
      <BowlerList />
    </>
  )
}

export default App
