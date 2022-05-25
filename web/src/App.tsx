import React from 'react';

export default () => {

  const callApi = async () => {
    const response = await fetch("https://localhost:3001/api/topic");
    const body = await response.json();
    console.log(body);
  };

  return (
    <div>
      <button onClick={callApi}>call api</button>
    </div>
  );
};
