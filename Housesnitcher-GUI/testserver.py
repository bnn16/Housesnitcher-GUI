from fastapi import Request, FastAPI
from pydantic import BaseModel

app = FastAPI()

class LoginData(BaseModel):
    username: str
    password: str

@app.post("/api/login")
async def login(data: LoginData):
    # print(await request.json())
    # print(request.headers)
    print(data)
    if data.username == "admin" and data.password == "admin":
        return {"status": "success", "auth": True, "scope": 2}
    return {"status": "failure", "auth": False, "scope": 0}
